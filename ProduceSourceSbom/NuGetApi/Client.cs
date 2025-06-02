using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;
using ProduceSourceSbom.NuGetApi.RestModel.Registration;
using ProduceSourceSbom.NuGetApi.RestModel.Search;

namespace ProduceSourceSbom.NuGetApi;

public class Client
{
    private readonly HttpClient _httpClient = new(new HttpClientHandler
    {
        AllowAutoRedirect = true,
        AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
    });

    public  PackageRegistration? GetPackageRegistration(NugetSearchResult searchResult)
    {
        if (!Program.Verbose)
        {
            Console.WriteLine($"Getting package registration for {searchResult.Id} {searchResult.Version}");
        }
        var regRequest = new HttpRequestMessage(HttpMethod.Get, searchResult.Registration);
        regRequest.Headers.Accept.Clear();
        regRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        

        var regResponse = _httpClient.SendAsync(regRequest).Result;

        if (!regResponse.IsSuccessStatusCode)
        {
            if (!Program.Verbose)
            {
                Console.WriteLine(
                    $"Error getting package registration for {searchResult.Id} {searchResult.Version} - RC = {regResponse.StatusCode}");
            }
            return null;
        }

        var regResponseContent = regResponse.Content.ReadAsStringAsync().Result;
        var packageRegistration = JsonSerializer.Deserialize<PackageRegistration>(regResponseContent);

        return packageRegistration;
    }

    public  NugetSearchResult? SearchForPackage(string packageId, string version)
    {
        if (!Program.Verbose)
        {
            Console.WriteLine($"Searching for package {packageId} {version}");
        }
        var packageQuery = string.Join("&", $"packageid:{packageId}", $"version={version}", "prerelease=true",
            "semVerLevel=2.0.0");

        var searchRequest =
            new HttpRequestMessage(HttpMethod.Get, $"https://azuresearch-usnc.nuget.org/query?q={packageQuery}");
        searchRequest.Headers.Accept.Clear();
        searchRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var searchResponse = _httpClient.Send(searchRequest);

        if (!searchResponse.IsSuccessStatusCode)
        {
            if (!Program.Verbose)
            {
                Console.WriteLine(
                    $"Error searching for package {packageId} {version} - RC = {searchResponse.StatusCode}");
            }
            return null;
        }

        var searchResultContent = searchResponse.Content.ReadAsStringAsync().Result;
        var searchResult = JsonSerializer.Deserialize<SearchResults>(searchResultContent);

        if (searchResult?.Registrations is null || searchResult.Registrations.Count == 0 ||
            searchResult.TotalHits is null || searchResult.TotalHits == 0)
        {
            if (!Program.Verbose)
            {
                Console.WriteLine($"No package found for {packageId} {version}");
            }
            return null;
        }

        if (searchResult.Registrations.Count != 1 || searchResult.TotalHits != 1)
        {
            if (!Program.Verbose)
            {
                Console.WriteLine($"Multiple packages found for {packageId} {version}");
            }
            return null;
        }

        var result = searchResult.Registrations.First();
        return result;
    }
}
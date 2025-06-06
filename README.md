# Spdx3

### A NuGet library (.NET 8) for creating, reading, and writing [Software Bills of Materials](https://www.ntia.gov/page/software-bill-materials) files in [SPDX 3](https://spdx.github.io/spdx-spec/v3.0.1/) format.

> [!NOTE]
> SPDX3 is primarily intended for tool-writers who want to create their own SBOMs directly and want a compliant data
> model and serialization utilities to do that.  
> It's not a utility/tool for inspecting artifacts, deriving SBOM material, or otherwise generating SBOMs for things.
> However, you can write code do to that inspection/derivation/generation and use this library to hold, serialize, and
> deserialize the data.

This library provides:

- A C# object model for the entire [SPDX3 spec](https://spdx.github.io/spdx-spec/v3.0.1/annexes/rdf-model/)
- Serialization and deserialization to/from JSON-LD format
- Validation
- Checking for [Lite domain](https://spdx.github.io/spdx-spec/v3.0.1/model/Lite/Lite/) compliance
- A full list of pre-created ```ListedLicense``` objects that correspond to
  the [SPDX License List](https://spdx.org/licenses/)

[![.NET 8](https://img.shields.io/badge/.NET-8-blue)]()
[![C#](https://img.shields.io/badge/C%23-lightgreen.svg?logo=data:image/svg%2bxml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCAzMiAzMiI+PHBhdGggc3R5bGU9ImxpbmUtaGVpZ2h0Om5vcm1hbDt0ZXh0LWluZGVudDowO3RleHQtYWxpZ246c3RhcnQ7dGV4dC1kZWNvcmF0aW9uLWxpbmU6bm9uZTt0ZXh0LWRlY29yYXRpb24tc3R5bGU6c29saWQ7dGV4dC10cmFuc2Zvcm06bm9uZTtibG9jay1wcm9ncmVzc2lvbjp0Yjtpc29sYXRpb246YXV0bzttaXgtYmxlbmQtbW9kZTpub3JtYWwiIGQ9Ik0gMTYgMi44ODI4MTI1IEwgMyA5LjM4MjgxMjUgTCAzIDIyLjYxNzE4OCBMIDE2IDI5LjExNzE4OCBMIDI5IDIyLjYxNzE4OCBMIDI5IDIyIEwgMjkgOS4zODI4MTI1IEwgMTYgMi44ODI4MTI1IHogTSAxNiA1LjExNzE4NzUgTCAyNyAxMC42MTcxODggTCAyNyAyMS4zODI4MTIgTCAxNiAyNi44ODI4MTIgTCA1IDIxLjM4MjgxMiBMIDUgMTAuNjE3MTg4IEwgMTYgNS4xMTcxODc1IHogTSAxMyAxMCBDIDkuNyAxMCA3IDEyLjcgNyAxNiBDIDcgMTkuMyA5LjcgMjIgMTMgMjIgQyAxNC41IDIyIDE1LjkwMDM5MSAyMS40IDE2LjkwMDM5MSAyMC41IEwgMTUuMTk5MjE5IDE5LjMwMDc4MSBDIDE0LjU5OTIxOSAxOS43MDA3ODEgMTMuOCAyMCAxMyAyMCBDIDEwLjggMjAgOSAxOC4yIDkgMTYgQyA5IDEzLjggMTAuOCAxMiAxMyAxMiBDIDEzLjggMTIgMTQuNTk5MjE5IDEyLjI5OTIxOSAxNS4xOTkyMTkgMTIuNjk5MjE5IEwgMTYuOTAwMzkxIDExLjUgQyAxNS45MDAzOTEgMTAuNiAxNC41IDEwIDEzIDEwIHogTSAxOCAxMiBMIDE4IDEzIEwgMTcgMTMgTCAxNyAxNSBMIDE4IDE1IEwgMTggMTcgTCAxNyAxNyBMIDE3IDE5IEwgMTggMTkgTCAxOCAyMCBMIDIwIDIwIEwgMjAgMTkgTCAyMiAxOSBMIDIyIDIwIEwgMjQgMjAgTCAyNCAxOSBMIDI1IDE5IEwgMjUgMTcgTCAyNCAxNyBMIDI0IDE1IEwgMjUgMTUgTCAyNSAxMyBMIDI0IDEzIEwgMjQgMTIgTCAyMiAxMiBMIDIyIDEzIEwgMjAgMTMgTCAyMCAxMiBMIDE4IDEyIHogTSAyMCAxNSBMIDIyIDE1IEwgMjIgMTcgTCAyMCAxNyBMIDIwIDE1IHoiIGZvbnQtd2VpZ2h0PSI0MDAiIGZvbnQtZmFtaWx5PSJzYW5zLXNlcmlmIiB3aGl0ZS1zcGFjZT0ibm9ybWFsIiBvdmVyZmxvdz0idmlzaWJsZSIvPjwvc3ZnPgo=)]()
[![NuGet](https://img.shields.io/badge/NuGet-004880?logo=nuget&logoColor=fff)]()
[![Linux](https://img.shields.io/badge/Linux-FCC624?logo=linux&logoColor=black)]()
[![macOS](https://img.shields.io/badge/macOS-000000?logo=apple&logoColor=F0F0F0)]()
[![Windows](https://img.shields.io/badge/Windows-blue.svg?logo=data:image/svg%2bxml;base64,PHN2ZyB3aWR0aD0iODAwcHgiIGhlaWdodD0iODAwcHgiIHZpZXdCb3g9IjAgMCAxNiAxNiIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiBmaWxsPSJub25lIj48cGF0aCBmaWxsPSIjRjM1MzI1IiBkPSJNMSAxaDYuNXY2LjVIMVYxeiIvPjxwYXRoIGZpbGw9IiM4MUJDMDYiIGQ9Ik04LjUgMUgxNXY2LjVIOC41VjF6Ii8+PHBhdGggZmlsbD0iIzA1QTZGMCIgZD0iTTEgOC41aDYuNVYxNUgxVjguNXoiLz48cGF0aCBmaWxsPSIjRkZCQTA4IiBkPSJNOC41IDguNUgxNVYxNUg4LjVWOC41eiIvPjwvc3ZnPg==)]()
[![GitHub Actions](https://img.shields.io/badge/GitHub_Actions-2088FF?logo=github-actions&logoColor=white)]()

[![build](https://img.shields.io/github/actions/workflow/status/mharrah/Spdx3/ci.yml?branch=main&style=flat-square)](https://github.com/mharrah/Spdx3/actions/workflows/ci.yml)
[![tests](https://img.shields.io/endpoint?style=flat-square&url=https://gist.githubusercontent.com/mharrah/e434f7b17274a026c153482b64e5cf91/raw/Spdx3-junit-tests.json)](https://github.com/mharrah/Spdx3/actions/workflows/ci.yml)
[![coverage](https://img.shields.io/endpoint?style=flat-square&url=https://gist.githubusercontent.com/mharrah/e434f7b17274a026c153482b64e5cf91/raw/Spdx3-cobertura-coverage.json)](https://mharrah.github.io/Spdx3/)
[![GitHub Issues or Pull Requests](https://img.shields.io/github/issues/mharrah/Spdx3)](https://github.com/mharrah/Spdx3/issues)

[![GitHub License](https://img.shields.io/github/license/mharrah/Spdx3)](https://github.com/mharrah/Spdx3/tree/main?tab=MIT-1-ov-file#)
[![GitHub Release](https://img.shields.io/github/v/release/mharrah/Spdx3)](https://github.com/mharrah/Spdx3/releases)
[![NuGet Version](https://img.shields.io/nuget/v/Spdx3)](https://www.nuget.org/packages/Spdx3/)

# Documentation

[Please see here](Spdx3/README.md)


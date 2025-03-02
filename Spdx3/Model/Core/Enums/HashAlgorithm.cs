namespace Spdx3.Model.Core.Enums;

/// <summary>
///     A mathematical algorithm that maps data of arbitrary size to a bit string.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Vocabularies/HashAlgorithm/
/// </summary>
public enum HashAlgorithm
{
    adler32,
    blake2b256,
    blake2b384,
    blake2b512,
    blake3,
    crystalsDilithium,
    crystalsKyber,
    falcon,
    md2,
    md4,
    md5,
    md6,
    other,
    sha1,
    sha224,
    sha256,
    sha384,
    sha3_224,
    sha3_256,
    sha3_384,
    sha3_512,
    sha512
}
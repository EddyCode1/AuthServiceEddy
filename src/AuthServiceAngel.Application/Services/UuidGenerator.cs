using System.Security.Cryptography;
using System.Text;

namespace AuthServiceAngel.Application.Service;
    public static class UuidGenerator
{
    private static readonly string Alphabet = "123456789ABCDEFGHJKMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz";

    public static string GenerateShortUUID()
    {
        using var rng = RandomNumberGenerator.Create();
        var bytes = new byte[12];
        rng.GetBytes(bytes);
    }
}

using System;
using System.Text;

public static class RandomHelper
{
    private static readonly Random random = new Random();
    private static readonly string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static string GenerateRandomMaKh()
    {
        StringBuilder result = new StringBuilder(5);
        for (int i = 0; i < 5; i++)
        {
            result.Append(chars[random.Next(chars.Length)]);
        }
        return result.ToString();
    }
}

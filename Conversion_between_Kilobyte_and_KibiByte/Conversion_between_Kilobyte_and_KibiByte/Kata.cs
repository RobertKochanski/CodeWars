using System;
using System.Globalization;
public class Kata
{
    public static string MemorySizeConversion(string memorySize)
    {
        var units = new (string unit, double factor, string targetUnit, double targetFactor)[]
        {
            ("kB", 1000, "KiB", 1024),
            ("MB", 1000000, "MiB", 1048576),
            ("GB", 1000000000, "GiB", 1073741824),
            ("TB", 1000000000000, "TiB", 1099511627776),
            ("KiB", 1024, "kB", 1000),
            ("MiB", 1048576, "MB", 1000000),
            ("GiB", 1073741824, "GB", 1000000000),
            ("TiB", 1099511627776, "TB", 1000000000000)
        };

        var splited = memorySize.Split(' ');
        double value = double.Parse(splited[0]);
        string unit = splited[1];

        foreach (var (unitName, factor, targetUnit, targetFactor) in units)
        {
            if (unitName == unit)
            {
                var result = Math.Round(value * factor / targetFactor, 3).ToString().Replace(",", ".");

                return $"{result} {targetUnit}";
            }
        }

        return "";
    }
}
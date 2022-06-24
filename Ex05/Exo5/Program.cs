using System;
using Exo5;

public static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Should_return_first_duplicate_value : {Tests.Should_return_first_duplicate_value()}");
    }

    public static int FirstDuplicateValue(List<int> values)
    {
        List<int> registeredValues = new();
        for(int i = 0; i < values.Count; ++i)
        {
            if (registeredValues.Contains(values[i]))
            {
                return values[i];
            }
            registeredValues.Add(values[i]);
        }
        return -1;
    }
}

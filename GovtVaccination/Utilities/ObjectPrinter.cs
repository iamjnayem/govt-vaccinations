using System;
using System.Reflection;

namespace GovtVaccination.Utilities;

public static class ObjectPrinter
{
    public static void PrintProperties(object obj)
    {
        if (obj == null)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Object is null.");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            
            return;
        }

        Type type = obj.GetType();
        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        Console.WriteLine();
        Console.WriteLine("***********************************");
        Console.WriteLine($"Object Type: {type.Name}");
        Console.WriteLine("***********************************");
        Console.WriteLine();
        
        
        Console.WriteLine();
        Console.WriteLine("######################################");
        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(obj, null);
            Console.WriteLine($"{property.Name}: {value}");
        }
        Console.WriteLine("######################################");
        Console.WriteLine();
    }
}
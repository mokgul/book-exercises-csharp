using System.Reflection;

namespace Chapter12;

public static class Exercise02
{
    public static void AllIOFilneNotFoundExceptions()
    {
        Type baseType = typeof(FileNotFoundException);

        var derivedTypes = AppDomain.CurrentDomain
            .GetAssemblies()
            .SelectMany(a =>
            {
                try
                {
                    return a.GetTypes();
                }
                catch (ReflectionTypeLoadException ex)
                {
                    return ex.Types.Where(t => t != null);
                }
            })
            .Where(t => t != null && baseType != t && baseType.IsAssignableFrom(t))
            .ToList();

        Console.WriteLine($"Наследници на {baseType.FullName}:\n");

        if (derivedTypes.Count == 0)
        {
            Console.WriteLine("Няма намерени подтипове.");
        }

        foreach (var type in derivedTypes)
        {
            Console.WriteLine(type.FullName);
        }
    }
}
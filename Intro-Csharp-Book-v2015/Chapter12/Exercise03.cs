using System.Reflection;

namespace Chapter12;

public static class Exercise03
{
    public static void AllApplicationExceptions()
    {
        Type baseType = typeof(ApplicationException);

        var derivedTypes = AppDomain.CurrentDomain
            .GetAssemblies()
            .SelectMany(assembly =>
            {
                try
                {
                    return assembly.GetTypes();
                }
                catch (ReflectionTypeLoadException ex)
                {
                    return ex.Types.Where(t => t != null);
                }
            })
            .Where(t => t != null && baseType != t && baseType.IsSubclassOf(baseType))
            .OrderBy(t => t.FullName)
            .ToList();

        Console.WriteLine($"Класове, наследяващи {baseType.FullName}:\n");

        foreach (var type in derivedTypes)
        {
            Console.WriteLine(type.FullName);
        }

        if (derivedTypes.Count == 0)
        {
            Console.WriteLine("Няма намерени подтипове.");
        }
    }
}
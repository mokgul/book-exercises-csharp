using System.Reflection;

namespace Chapter12;

public static class Exercise01
{
    public static void AllIOExceptions()
    {
        var ioExceptionType = typeof(IOException);

        var exceptions = AppDomain.CurrentDomain
            .GetAssemblies()
            .SelectMany(a =>
            {
                try { return a.GetTypes(); }
                catch (ReflectionTypeLoadException ex) { return ex.Types.Where(t => t != null); }
            })
            .Where(t => t != null && !t.IsAbstract && ioExceptionType.IsAssignableFrom(t))
            .ToList();

        foreach (var type in exceptions)
        {
            try
            {
                // Try to create with the default constructor
                var instance = (IOException?)Activator.CreateInstance(type, nonPublic: true);
                Console.WriteLine($"{type.FullName}");
            }
            catch
            {
                Console.WriteLine($"{type.FullName} (No default constructor)");
            }
        }

    }
}
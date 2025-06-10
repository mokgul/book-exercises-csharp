namespace Chapter02;

public static class Exercise02
{
    private static readonly Dictionary<Type, string> TypeAliases = new Dictionary<Type, string>
    {
        { typeof(float), "float" },
        { typeof(double), "double" },
        { typeof(decimal), "decimal" }
    };

    public static void DeclareNumbers()
    {
        object[] numbers = [
            34.567839023,                      // double
            12.345f,                           // float
            8923.1234857,                      // double (too precise for float)
            3456.091124875956542151256683467m  // decimal
        ];

        Console.WriteLine(string.Join(Environment.NewLine,
            numbers.Select(n => $"Type: {TypeAliases[n.GetType()]}. Value: {n}")));
    }
}
namespace Chapter02;

public static class Exercise01
{
    private static readonly Dictionary<Type, string> TypeAliases = new Dictionary<Type, string>
    {
        { typeof(byte), "byte" },
        { typeof(sbyte), "sbyte" },
        { typeof(short), "short" },
        { typeof(ushort), "ushort" },
        { typeof(int), "int" },
        { typeof(uint), "uint" },
        { typeof(long), "long" },
        { typeof(ulong), "ulong" },
        { typeof(float), "float" },
        { typeof(double), "double" },
        { typeof(decimal), "decimal" }
    };

    public static void DeclareNumbers()
    {
        object[] numbers =
        [
            (ushort)52130,
            (sbyte)-115,
            4825932,
            (byte)97,
            (short)-10000,
            (ushort)20000,
            (byte)224,
            970700000L,
            (byte)112,
            (sbyte)-44,
            -1000000,
            (short)1990,
            123456789123456789UL
        ];
        Console.WriteLine(string.Join(Environment.NewLine,
            numbers.Select(n => $"Type: {TypeAliases[n.GetType()]}. Value:{n}")));
    }
}
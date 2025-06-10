namespace Chapter02;

public static class Exercise08
{
    public static void HelloWorldAsObjectWithCasting()
    {
        string str1 = "Hello";
        string str2 = "World";
        object fullString = str1 + " " + str2;
        string str = (string)fullString;
        Console.WriteLine(str);
    }
}
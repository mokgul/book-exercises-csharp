namespace Chapter02;

public static class Exercise07
{
    public static void HelloWorldAsObject()
    {
        string str1 = "Hello";
        string str2 = "World";
        object fullString;
        fullString = str1 + " " + str2;
        Console.WriteLine(fullString);
    }
}
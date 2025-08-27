namespace Chapter03;

public static class Grade
{
    public static void IsExcellent()
    {
        double grade = double.Parse(Console.ReadLine());
        if (grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
    }

    public static void IsExcellentOrNot()
    {
        double grade = double.Parse(Console.ReadLine());
        if (grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not Excellent!");
        }
    }
}
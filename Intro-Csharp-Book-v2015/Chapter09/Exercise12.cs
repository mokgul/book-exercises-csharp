namespace Chapter09;

public static class Exercise12
{
    public static void SumTwoPolynomials()
    {
        int[] first = new int[3];
        int[] second = new int[3];
        int[] result = new int[3];

        Console.WriteLine("Enter the coefficients of the first polynomial:");
        Console.WriteLine("Enter the first coefficient: a=");
        first[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second coefficient: b=");
        first[1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third coefficient: c=");
        first[2] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the coefficients of the second polynomial:");
        Console.WriteLine("Enter the first coefficient: a=");
        second[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second coefficient: b=");
        second[1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third coefficient: c=");
        second[2] = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        {
            result[i] = first[i] + second[i];
        }
        string output = string.Empty;
        for (int i = 0; i < 3; i++)
        {
            if (i == 0 && result[i] != 0)
            {
                output += (result[i] + "x" + '\u00B2');
            }

            if (i == 1 && result[i] != 0)
            {
                output += ((result[i] > 0 ? " + " : " ") + result[i] + "x");
            }

            if (i == 2 && result[i] != 0)
            {
                output += ((result[i] > 0 ? " + " : " ") + result[i]);
            }
        }

        Console.WriteLine($"The result is: {output}");
    }
}
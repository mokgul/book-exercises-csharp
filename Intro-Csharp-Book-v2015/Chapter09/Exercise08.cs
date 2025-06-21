namespace Chapter09;

public static class Exercise08
{
    public static int SumArrays(int[] x, int[] y)
    {
        string firstNumber = string.Empty;
        for(int i = x.Length - 1; i >= 0; i--)
            firstNumber += x[i];

        string secondNumber = string.Empty;
        for(int i = y.Length - 1; i >= 0; i--)
            secondNumber += y[i];

        int b = 0;
        bool valid = int.TryParse(firstNumber, out var a) && int.TryParse(secondNumber, out b);
        if (valid)
        {
            return a + b;
        }
        return -1;
    }
}
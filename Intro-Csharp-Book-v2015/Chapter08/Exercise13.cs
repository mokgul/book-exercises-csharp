namespace Chapter08;

public static class Exercise13
{
    public static void ConvertToCustom(int N, int S, int D)
    {
// Step 1: Convert input N from base S to decimal
        int decimalValue = 0;
        int multiplier = 1;

        while (N > 0)
        {
            int digit = N % 10;
            if (digit >= S)
            {
                Console.WriteLine($"Invalid digit '{digit}' for base {S}");
                return;
            }

            decimalValue += digit * multiplier;
            multiplier *= S;
            N /= 10;
        }

        // Step 2: Convert decimal to base D
        int result = 0;
        int place = 1;

        while (decimalValue > 0)
        {
            int remainder = decimalValue % D;
            result += remainder * place;
            place *= 10;
            decimalValue /= D;
        }

        Console.WriteLine(result);
    }
}
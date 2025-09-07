namespace Chapter05;

public static class NumbersInLoops
{
    public static void PrintOneToHundred()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void PrintNumbersWithLastDigitSeven()
    {
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 10 == 7)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void SumNumbers()
    {
        int qty = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= qty; i++)
        {
            int current = int.Parse(Console.ReadLine());
            sum += current;
        }

        Console.WriteLine(sum);
    }

    public static void FindBiggestNumber()
    {
        int biggest = int.MinValue;
        int qty = int.Parse(Console.ReadLine());
        for (int i = 1; i <= qty; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (current > biggest)
            {
                biggest = current;
            }
        }

        Console.WriteLine(biggest);
    }

    public static void FindSmallestNumber()
    {
        int smallest = int.MaxValue;
        int qty = int.Parse(Console.ReadLine());

        for (int i = 1; i <= qty; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (current < smallest)
            {
                smallest = current;
            }
        }

        Console.WriteLine(smallest);
    }

    public static void IsLeftRightSumEqual()
    {
        int qty = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;
        for (int i = 1; i <= 2 * qty; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (i <= qty)
            {
                leftSum += current;
            }
            else
            {
                rightSum += current;
            }
        }

        Console.WriteLine(leftSum == rightSum ? $"Yes, sum = {leftSum}" : $"No, diff = {Math.Abs(leftSum - rightSum)}");
    }

    public static void IsOddEvenSumEqual()
    {
        int qty = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;
        for (int i = 1; i <= qty; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                oddSum += current;
            }
            else
            {
                evenSum += current;
            }
        }

        bool areEqual = oddSum == evenSum;
        Console.WriteLine(areEqual ? "Yes" : "No");
        Console.WriteLine(areEqual ? $"Sum = {oddSum}" : $"Diff = {Math.Abs(oddSum - evenSum)}");
    }

    public static void FindElementEqualSumElements()
    {
        int qty = int.Parse(Console.ReadLine());
        int[] numbers = new int[qty];
        for (int i = 0; i < qty; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sum = numbers.Sum();
        bool elementExist = numbers.Any(x => x == sum);

        if (elementExist)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {sum}");
        }
        else
        {
            Console.WriteLine("No");
            int biggest = numbers.Max();
            Console.WriteLine($"Diff = {Math.Abs(biggest - sum)}");
        }
    }

    public static void CalculateSumsOfOddEvenPositions()
    {
        double oddSum = 0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;
        double evenSum = 0;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += num;
                if (num < evenMin) evenMin = num;
                if (num > evenMax) evenMax = num;
            }
            else
            {
                oddSum += num;
                if (num < oddMin) oddMin = num;
                if (num > oddMax) oddMax = num;
            }
        }
        Console.WriteLine($"OddSum={oddSum:f2},");
        if (n == 0)
        {
            Console.WriteLine($"OddMin=No,");
            Console.WriteLine($"OddMax=No,");
        }
        else
        {
            Console.WriteLine($"OddMin={oddMin:f2},");
            Console.WriteLine($"OddMax={oddMax:f2},");
        }
        Console.WriteLine($"EvenSum={evenSum:f2},");
        if (n == 0 || n == 1)
        {
            Console.WriteLine($"EvenMin=No,");
            Console.WriteLine($"EvenMax=No");
        }
        else
        {
            Console.WriteLine($"EvenMin={evenMin:f2},");
            Console.WriteLine($"EvenMax={evenMax:f2}");
        }
    }

    public static void PairsSum()
    {
        int sum = 0;
        int sumCheck = 0;
        int diff = int.MinValue;
        int maxDiff = 0;
        bool check = false;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                sum = numOne + numTwo;
                sumCheck = sum;
            }
            else if (i > 0)
            {
                maxDiff = Math.Abs(sum - (numOne + numTwo));
                if (maxDiff > diff) diff = maxDiff;
                sum = numOne + numTwo;
                if (sum == sumCheck) check = true;
            }
        }
        if (check || n == 1)
            Console.WriteLine($"Yes, value={sum}");
        else
            Console.WriteLine($"No, maxdiff={diff}");
    }
}
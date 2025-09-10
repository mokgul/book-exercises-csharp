namespace Chapter07;

public static class Numbers
{
    public static void PrintNumbersToNWithStep(int n)
    {
        for (int i = 1; i <= n; i += 3)
        {
            Console.WriteLine(i);
        }
    }

    public static void PrintNumbersInReverseOrder(int n)
    {
        for (int i = n; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }

    public static void PrintPowersOfTwo(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(Math.Pow(2, i));
        }
    }

    public static void PrintEvenPowersOfTwo(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(Math.Pow(2, i));
        }
    }

    public static void PrintSequence2kPlus1(int n)
    {
        int num = 1;
        while (num <= n)
        {
            Console.WriteLine(num);
            num = 2 * num + 1;
        }
    }

    public static void InRange()
    {
        int num = int.Parse(Console.ReadLine());
        while (num < 1 || num > 100)
        {
            Console.WriteLine("Invalid number!");
            num = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"The number is: {num}");
    }

    public static void EuclideanAlgorithm()
    {
        int num = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        while (num2 != 0)
        {
            var old = num2;
            num2 = num % num2;
            num = old;
        }
        Console.WriteLine($"GCD = {num}");
    }

    public static void CalculateFactorial(int n)
    {
        int fact = 1;
        do
        {
            fact = fact * n;
            n--;
        }
        while (n > 1);
        Console.WriteLine($"{fact}");
    }

    public static void SumDigits(int number)
    {
        int sum = 0;
        do
        {
            sum = number % 10;
            number /= 10;
        }
        while (number > 0);
        Console.WriteLine($"Sum of digits: {sum}");
    }

    public static void IsPrime(int number)
    {
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime ? "Prime" : "Not prime");
    }

    public static void IsEven()
    {
        int n = 0;
        while (true)
        {
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) break;
            Console.WriteLine("The number is not even.");
        }
        Console.WriteLine($"Even number entered: {n}");
    }

    public static void PrintFibonacci(int n)
    {
        int f0 = 1;
        int f1 = 1;
        for (int i = 0; i < n - 1; i++)
        {
            int next = f0 + f1;
            f0 = f1;
            f1 = next;
        }
        Console.WriteLine(f1);
    }

    public static void PrintPyramid(int n)
    {
        int num = 1;
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                if(col > 1)
                    Console.Write(" ");
                Console.Write(num);
                num++;
                if (num > n) break;
            }
            Console.WriteLine();
            if(num > n) break;
        }
    }

    public static void PrintTable(int n)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                var num = row + col + 1;
                if (num > n)
                {
                    num = 2 * n - num;
                }
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

    public static void MagicNumbers(int number)
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int m = 1; m <= 9; m++)
                    {
                        for (int n = 1; n <= 9; n++)
                        {
                            for (int p = 1; p <= 9; p++)
                            {
                                int current = i * j * k * m * n * p;
                                if (current == number)
                                {
                                    Console.Write($"{i}{j}{k}{m}{n}{p} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public static void PrintNumbersWithStop()
    {
        int start = int.Parse(Console.ReadLine());
        int end  = int.Parse(Console.ReadLine());
        int stop  = int.Parse(Console.ReadLine());

        for (int i = end; i >= start; i--)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                if (i == stop) break;
                Console.Write($"{i} ");
            }
        }
    }

    public static void SpecialNumbers()
    {
        int a = int.Parse(Console.ReadLine());
        int t = 0;
        for (int i = 1111; i <= 9999; i++)
        {
            string text = Convert.ToString(i);
            for (int h = 0; h < text.Length; h++)
            {
                int s = int.Parse(text[h].ToString());
                if (s == 0) continue;
                if (a % s == 0)
                {
                    t++;
                }
                else
                {
                    t = 0;
                    break;
                }
            }
            if (t == 4)
            {

                Console.Write(i + " ");
            }
            t = 0;
        }
    }

    public static void DigitOperations()
    {
        int number = int.Parse(Console.ReadLine());

        int a = number / 100;
        int b = (number / 10) % 10;
        int c = number % 10;

        int N = a + b;
        int M = a + c;

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write(number + " ");

                if (number % 5 == 0)
                {
                    number -= a;
                }
                else if (number % 3 == 0)
                {
                    number -= b;
                }
                else
                {
                    number += c;
                }
            }
            Console.WriteLine();
        }
    }
}
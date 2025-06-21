// See https://aka.ms/new-console-template for more information

using Chapter09;

// Exercise 01
Exercise01.PrintHello("Peter");

// Exercise 02
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

int GetMax(int x, int y) => Exercise02.GetMax(x, y);
int max = GetMax(a, GetMax(b, c));
Console.WriteLine(max);

// Exercise 03
Console.WriteLine(Exercise03.ReturnLastDigitAsText(512));

// Exercise 04
int count = Exercise04.ReturnCountRepeatingElements([1, 1, 3, 2, 1, 4]);
Console.WriteLine(count);

// Exercise 05
Console.WriteLine(Exercise05.ElementValueComparedToNeighbours(2, [1, 2, 3, 4, 5]));
Console.WriteLine(Exercise05.ElementValueComparedToNeighbours(2, [1, 4, 3, 2, 5]));
Console.WriteLine(Exercise05.ElementValueComparedToNeighbours(2, [1, 4, 3, 2, 5]));
Console.WriteLine(Exercise05.ElementValueComparedToNeighbours(2, [1, 2, 3, 2, 5]));

// Exercise 06
Console.WriteLine(Exercise06.ReturnIndex([1, 2, 3, 4, 5]));
Console.WriteLine(Exercise06.ReturnIndex([1, 2, 3, 4, 3]));

// Exercise 07
string result = Exercise07.ReverseNumber(256);
Console.WriteLine(result);

// Exercise 08
int sum = Exercise08.SumArrays([0, 2, 1], [0, 8, 1]);
Console.WriteLine(sum != - 1 ? sum : "Invalid input");

// Exercise 09
int biggest = Exercise09.GetBiggestElementInArrayRange(1, 5, [0, 2, 3, 7, 2, 3, 11]);
Console.WriteLine(biggest);

// Exercise 10
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(Exercise10.CalculateFactorial(i));
}

// Exercise 11
Exercise11.TaskSolver();

// Exercise 12
Exercise12.SumTwoPolynomials();

// Exercise 13
Exercise13.MultiplyPolynomials([3, 1, -3], [0, 1, -1]);
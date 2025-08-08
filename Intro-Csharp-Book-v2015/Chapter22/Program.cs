// See https://aka.ms/new-console-template for more information

using System.Text;
using Chapter22;

// Exercise 01
StringBuilder sb = new StringBuilder("Hello, StringBuilder!");

StringBuilder part1 = sb.Substring(0, 5);   // "Hello"
StringBuilder part2 = sb.Substring(7, 6);   // "String"

Console.WriteLine(part1.ToString());
Console.WriteLine(part2.ToString());

// Exercise 02
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

int total = EnumerableExtensions.Sum(numbers);
int min = EnumerableExtensions.Min(numbers);
int max = EnumerableExtensions.Max(numbers);
double average = EnumerableExtensions.Average(numbers);

Console.WriteLine(total);
Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine(average);
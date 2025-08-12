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

// Exercise 03
Exercise03.FindStudents([
    new Student ( "Ivan", "Petrov", 33 ),
    new Student ( "Georgi", "Ivanov", 35 ),
    new Student ( "Petar", "Andreev", 31 ),
    new Student ( "Alex", "Zlatev", 32 )
]);

// Exercise 04
Exercise04.FindStudentsInAgeRange([
    new Student ( "Ivan", "Petrov", 33 ),
    new Student ( "Georgi", "Ivanov", 22 ),
    new Student ( "Petar", "Andreev", 21 ),
    new Student ( "Alex", "Zlatev", 29 )
]);

// Exercise 05
Exercise05.SortStudentList([
    new Student ( "Ivan", "Petrov", 33 ),
    new Student ( "Georgi", "Ivanov", 22 ),
    new Student ( "Petar", "Andreev", 21 ),
    new Student ( "Alex", "Zlatev", 29 )
]);

// Exercise 06
Exercise06.FindNumbers([1, 3, 7, 14, 21, 35, 42, 49, 63, 70, 84, 105]);

// Exercise 07
Exercise07.UppercaseEveryWord("this iS a Sample sentence.");
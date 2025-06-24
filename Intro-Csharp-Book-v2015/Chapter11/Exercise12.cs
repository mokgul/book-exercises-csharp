using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Chapter11;

public static class Exercise12
{
    public static void MathOperationsFromString(string s)
    {
        double result = EvaluateExpression(s);
        Console.WriteLine($"Result: {result:F2}");
    }

    private static double EvaluateExpression(string expression)
    {
        expression = Regex.Replace(expression, @"pow\(([^,]+),([^)]+)\)", m =>
        {
            double a = EvaluateExpression(m.Groups[1].Value);
            double b = EvaluateExpression(m.Groups[2].Value);
            return Math.Pow(a, b).ToString(CultureInfo.InvariantCulture);
        });

        expression = Regex.Replace(expression, @"sqrt\(([^)]+)\)", m =>
        {
            double val = EvaluateExpression(m.Groups[1].Value);
            return Math.Sqrt(val).ToString(CultureInfo.InvariantCulture);
        });

        expression = Regex.Replace(expression, @"ln\(([^)]+)\)", m =>
        {
            double val = EvaluateExpression(m.Groups[1].Value);
            return Math.Log(val).ToString(CultureInfo.InvariantCulture);
        });

        var table = new DataTable();
        var value = table.Compute(expression, "");

        return Convert.ToDouble(value);
    }
}
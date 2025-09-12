using System.Globalization;

namespace Chapter09;

public static class NumericExpression
{
    public static void Solve()
    {
        string input = Console.ReadLine();
        input = input.TrimEnd('='); // махаме '=' от края
        
        while (input.Contains("("))
        {
            int openIndex = input.LastIndexOf('('); // последна отворена скоба
            int closeIndex = input.IndexOf(')', openIndex);

            string inside = input.Substring(openIndex + 1, closeIndex - openIndex - 1);

            double result = EvaluateLeftToRight(inside);
            
            input = input.Substring(0, openIndex) + result.ToString(CultureInfo.InvariantCulture) + input.Substring(closeIndex + 1);
        }
        
        double finalResult = EvaluateLeftToRight(input);

        Console.WriteLine($"{finalResult:F2}");
    }

    private static double EvaluateLeftToRight(string expr)
    {
        var tokens = new System.Collections.Generic.List<string>();
        string number = "";

        foreach (char c in expr)
        {
            if (char.IsDigit(c) || c == '.')
            {
                number += c;
            }
            else if (c == '+' || c == '-' || c == '*' || c == '/')
            {
                if (number.Length > 0)
                {
                    tokens.Add(number);
                    number = "";
                }
                tokens.Add(c.ToString());
            }
        }
        if (number.Length > 0)
        {
            tokens.Add(number);
        }
        
        double result = double.Parse(tokens[0], CultureInfo.InvariantCulture);

        for (int i = 1; i < tokens.Count; i += 2)
        {
            string op = tokens[i];
            double next = double.Parse(tokens[i + 1], CultureInfo.InvariantCulture);

            switch (op)
            {
                case "+": result += next; break;
                case "-": result -= next; break;
                case "*": result *= next; break;
                case "/": result /= next; break;
            }
        }

        return result;
    }
}
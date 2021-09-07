namespace Chapter04;

public static class Operations
{
    public static void Calculate()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        char op =  char.Parse(Console.ReadLine());

        string result = string.Empty;
        
        switch (op)
        {
            case '+':
            case '-':
            case '*':
            {
                int calculation = op switch
                {
                    '+' => first + second,
                    '-' => first - second,
                    '*' => first * second,
                    _ => 0
                };
                string oddOrEven = calculation % 2 == 0 ? "even" : "odd";
                result = $"{first} {op} {second} = {calculation} - {oddOrEven}";
                break;
            }
                
            case '/':
                if (second == 0)
                {
                    result = $"Cannot divide {first} by zero";
                }
                else
                {
                    double calculation = (double)first / second;
                    result = $"{first} {op} {second} = {calculation:F2}";
                }
                break;
            case '%':
                if (second == 0)
                {
                    result = $"Cannot divide {first} by zero";
                }
                else
                {
                    int calculation = first % second;
                    result = $"{first} {op} {second} = {calculation}";
                }
                break;

            default:
                result = "Invalid operator";
                break;
        }
        Console.WriteLine(result);
    }
}
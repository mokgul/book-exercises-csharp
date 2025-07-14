namespace Chapter14;

public class Fraction
{
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }
    
    public decimal DecimalValue => (decimal)Numerator / Denominator;

    public Fraction(int numerator, int denominator)
    {
        if(denominator == 0)
            throw new DivideByZeroException("Denominator cannot be 0");
        
        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }
        
        int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
        Numerator = numerator / gcd;
        Denominator = denominator / gcd;
    }

    public static Fraction Parse(string input)
    {
        if (string.IsNullOrEmpty(input))
            throw new FormatException("Input cannot be null or empty");
        
        string[] parts = input.Trim().Split('/');
        if (parts.Length != 2)
            throw new FormatException("Input must contain exactly two numbers");
        
        int numerator = int.Parse(parts[0]);
        int denominator = int.Parse(parts[1]);
        return new Fraction(numerator, denominator);
    }
    
    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int oldB = b;
            b = a % b;
            a = oldB;
        }
        return a;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}
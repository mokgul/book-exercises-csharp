namespace Chapter02;

public static class Salary
{
    public static void Calculate()
    {
        int daysPerMonth = int.Parse(Console.ReadLine());
        double dailyIncome = double.Parse(Console.ReadLine());
        double usdRate = double.Parse(Console.ReadLine());
        
        double salary = 12 * (daysPerMonth * dailyIncome);
        double bonus = 2.5 * (daysPerMonth * dailyIncome);
        
        double total = salary + bonus;
        double afterTaxes = total - total * 0.25;
        double bgn = afterTaxes * usdRate;
        double dailyRate = bgn / 365;
        Console.WriteLine($"{dailyRate:f2}");
    }
}
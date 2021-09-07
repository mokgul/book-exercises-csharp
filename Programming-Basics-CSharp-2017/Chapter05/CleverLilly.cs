namespace Chapter05;

public static class CleverLilly
{
    public static void Calculate()
    {
        int age = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        double sum = 0;
        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                sum += (i / 2 ) * 10;
            }
            else
            {
                sum += toyPrice - 1;
            }
        }
        
        if (sum >= washingMachinePrice)
            Console.WriteLine($"Yes! {(sum - washingMachinePrice):f2}");
        else
            Console.WriteLine($"No! {(washingMachinePrice - sum):f2}");
    }
}
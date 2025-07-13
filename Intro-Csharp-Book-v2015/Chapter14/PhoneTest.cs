namespace Chapter14;

public class PhoneTest
{
    public static void Test()
    {
        // Battery and Display objects
        Battery battery1 = new Battery("BL-5C", BatteryType.LiIon)
        {
            IdleTime = 200,
            HoursTalk = 10
        };
        Display display1 = new Display("16M", 5.5);

        Battery battery2 = new Battery("BP-6MT", BatteryType.NiMH)
        {
            IdleTime = 150,
            HoursTalk = 8
        };
        Display display2 = new Display("256K", 4.0);

        Battery battery3 = new Battery("BL-4U", BatteryType.NiCd)
        {
            IdleTime = 100,
            HoursTalk = 6
        };
        Display display3 = new Display("65K", 3.5);

        // Creating Phone instances
        Phone phone1 = new Phone("Galaxy S22", "Samsung", battery1, display1, "Alice", 799.99);
        Phone phone2 = new Phone("iPhone 13", "Apple", battery2, display2, "Bob", 999.99);
        Phone phone3 = new Phone("Nokia 6300", "Nokia", battery3, display3);

        // Setting the static field for NokiaN95 example
        Phone.NokiaN95 = "Nokia N95 (classic)";

        // Display phone info
        phone1.GetInfo();
        Console.WriteLine("----------------------");
        phone2.GetInfo();
        Console.WriteLine("----------------------");
        phone3.GetInfo();
        Console.WriteLine($"Static phone model (NokiaN95): {Phone.NokiaN95}");
    }
}
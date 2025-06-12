namespace Chapter04;

public static class Exercise03
{
    public static void ReadCompanyInformation()
    {
        // Company details
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter company address: ");
        string address = Console.ReadLine();

        Console.Write("Enter company phone number: ");
        string phone = Console.ReadLine();

        Console.Write("Enter company fax number: ");
        string fax = Console.ReadLine();

        Console.Write("Enter company website: ");
        string website = Console.ReadLine();

        // Manager details
        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Enter manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Enter manager phone number: ");
        string managerPhone = Console.ReadLine();

        // Print all info
        Console.WriteLine("\n--- Company Information ---");
        Console.WriteLine($"Name   : {companyName}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Phone  : {phone}");
        Console.WriteLine($"Fax    : {fax}");
        Console.WriteLine($"Website: {website}");

        Console.WriteLine("\n--- Manager Information ---");
        Console.WriteLine($"Name   : {managerFirstName} {managerLastName}");
        Console.WriteLine($"Phone  : {managerPhone}");
    }
}
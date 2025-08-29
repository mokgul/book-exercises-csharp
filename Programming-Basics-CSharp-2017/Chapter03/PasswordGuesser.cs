namespace Chapter03;

public static class PasswordGuesser
{
    public static void Guess()
    {
        string password = "s3cr3t!P@ssw0rd";
        string guess = Console.ReadLine();
        if (guess == password)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}
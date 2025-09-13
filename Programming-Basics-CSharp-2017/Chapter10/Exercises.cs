namespace Chapter10;

public static class Exercises
{
   public static void GetMin(int a, int b) => Math.Min(a, b);

   public static void RepeatString(string s, int times)
   {
      for (int i = 0; i < times; i++)
         s += s;
      Console.WriteLine(s);
   }

   public static void PrintNthDigit(int n, int index)
   {
      char digit = n.ToString()[index];
      Console.WriteLine(digit);
   }

   public static void ConvertTo(int number, int numberBase)
   {
      var converted = Convert.ToString(number, numberBase);
      Console.WriteLine(converted);
   }

   public static void Notifications()
   {
      int n = int.Parse(Console.ReadLine());

      for (int i = 0; i < n; i++)
      {
         ReadAndProcessMessage();
      }
   }
   
   static void ShowSuccessMessage(string operation, string message)
   {
      string title = $"Successfully executed {operation}.";
      Console.WriteLine(title);
      Console.WriteLine(new string('=', title.Length));
      Console.WriteLine(message + ".");
      Console.WriteLine();
   }

   static void ShowWarningMessage(string message)
   {
      string title = $"Warning: {message}.";
      Console.WriteLine(title);
      Console.WriteLine(new string('=', title.Length));
      Console.WriteLine();
   }

   static void ShowErrorMessage(string operation, string message, int errorCode)
   {
      string title = $"Error: Failed to execute {operation}.";
      Console.WriteLine(title);
      Console.WriteLine(new string('=', title.Length));
      Console.WriteLine($"Reason: {message}.");
      Console.WriteLine($"Error code: {errorCode}.");
      Console.WriteLine();
   }

   static void ReadAndProcessMessage()
   {
      string messageType = Console.ReadLine();

      if (messageType == "success")
      {
         string operation = Console.ReadLine();
         string message = Console.ReadLine();
         ShowSuccessMessage(operation, message);
      }
      else if (messageType == "warning")
      {
         string message = Console.ReadLine();
         ShowWarningMessage(message);
      }
      else if (messageType == "error")
      {
         string operation = Console.ReadLine();
         string message = Console.ReadLine();
         int errorCode = int.Parse(Console.ReadLine());
         ShowErrorMessage(operation, message, errorCode);
      }
   }
}
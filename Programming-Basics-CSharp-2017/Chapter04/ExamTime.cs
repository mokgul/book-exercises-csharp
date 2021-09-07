namespace Chapter04;

public static class ExamTime
{
    public static void Calculate()
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinute = int.Parse(Console.ReadLine());
        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinute = int.Parse(Console.ReadLine());
        
        int examTime =  examHour * 60 + examMinute;
        int arrivalTime =  arrivalHour * 60 + arrivalMinute;
        int difference = examTime - arrivalTime;
        
        int hours =  Math.Abs(difference / 60);
        int minutes = Math.Abs(difference % 60);

        switch (difference)
        {
            case > 30:
                Console.WriteLine("Early");
                Console.WriteLine(hours > 0
                    ? $"{hours}:{minutes:D2} hours before the start"
                    : $"{minutes:D2} minutes before the start");
                break;
            case < 0:
                Console.WriteLine("Late");
                Console.WriteLine(hours > 0
                    ? $"{hours}:{minutes:D2} hours after the start"
                    :  $"{minutes:D2} minutes after the start");
                break;
            default:
                Console.WriteLine("On time");
                if(minutes != 0)
                    Console.WriteLine($"{minutes:D2} minutes before the start");
                break;
        }
    }
}
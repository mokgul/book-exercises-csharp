namespace Chapter08;

public static class Exercise01
{
    public static void ConvertNumberToBinary(bool isInteger, int number, double num = 0.0)
    {
        if (isInteger)
        {
            var binary = string.Empty;
            while (number != 0)
            {
                binary += number % 2;
                number /= 2;
            }
            Console.WriteLine(binary);
        }
        else
        {
            byte[] bytes = BitConverter.GetBytes(num); // little-endian
            Array.Reverse(bytes); // convert to big-endian for readability

            string binary = "";
            foreach (byte b in bytes)
            {
                binary += Convert.ToString(b, 2).PadLeft(8, '0');
            }
            Console.WriteLine(binary);
        }
    }
}
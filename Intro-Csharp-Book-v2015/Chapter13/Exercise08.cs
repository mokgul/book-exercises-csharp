using System.Text;

namespace Chapter13;

public static class Exercise08
{
    public static void ConvertToUnicode(string str)
    {
        var sb = new StringBuilder();

        foreach (char c in str)
        {
            sb.AppendFormat("\\u{0:X4}", (int)c);
        }

        Console.WriteLine(sb.ToString());
    }
}
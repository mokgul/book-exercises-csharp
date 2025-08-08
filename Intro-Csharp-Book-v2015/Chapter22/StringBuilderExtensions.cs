using System.Text;

namespace Chapter22;

public static class StringBuilderExtensions
{
    public static StringBuilder Substring(this StringBuilder builder, int index, int length)
    {
        if (builder == null)
            throw new ArgumentNullException(nameof(builder));

        if (index < 0 || length < 0 || index + length > builder.Length)
            throw new ArgumentOutOfRangeException();

        StringBuilder result = new StringBuilder(length);
        for (int i = index; i < index + length; i++)
        {
            result.Append(builder[i]);
        }
        return result;
    }
}
namespace Chapter22;

public static class EnumerableExtensions
{
    public static int Sum(this IEnumerable<int> source)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));
        
        int sum = 0;
        foreach (var item in source)
            sum += item;
        return sum;
    }
    
    public static int Min(this IEnumerable<int> source)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));
        int min = Int32.MaxValue;

        foreach (var item in source)
        {
            if (item < min)
                min = item;
        }
        return min;
    }

    public static int Max(this IEnumerable<int> source)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));
        int max = Int32.MinValue;

        foreach (var item in source)
        {
            if (item > max)
                max = item;
        }
        return max;
    }

    public static double Average(this IEnumerable<int> source)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));
        
        double sum = 0;
        double count = 0;
        foreach (var item in source)
        {
            sum += item;
            count++;
        }
        return sum / count;
    }
}
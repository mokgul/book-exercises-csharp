namespace Chapter03;

public static class Exercise09
{
    private static readonly Dictionary<string, int> RectangleSize = new Dictionary<string, int>()
    {
        { "xMin", -1 }, { "xMax", 5 }, { "yMin", 1 }, { "yMax", 5 }
    };
    private const int CircleRadius = 5;

    public static void IsPointInsideCircleAndOutsideRectangle(int x, int y)
    {
        string resultCircle = x <= 5 && y <= 5 ? "Inside the Circle" : "Outside the Circle";

        string resultRectangle =
            x >= RectangleSize["xMin"] &&
            x <= RectangleSize["xMax"] &&
            y >= RectangleSize["yMin"] &&
            y <= RectangleSize["yMax"] ? "Inside the Rectangle" : "Outside the Rectangle";
        Console.WriteLine($"The point is {resultCircle} and {resultRectangle}");
    }
}
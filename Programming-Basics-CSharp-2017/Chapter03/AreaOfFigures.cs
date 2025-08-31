namespace Chapter03;

public static class AreaOfFigures
{
    public static void Calculate()
    {
        Console.WriteLine("Enter a figure (square, rectangle, circle or triangle):");
        string figure = Console.ReadLine();
        double area = 0.00;
        if (figure == "square")
        {
            double side = double.Parse(Console.ReadLine());
            area = side * side;
        }
        else if (figure == "rectangle")
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            area = sideA * sideB;
        }
        else if (figure == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;
        }
        else if (figure == "triangle")
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            area = sideA * sideB / 2;
        }
        else
        {
            Console.WriteLine("not a figure");
        }
        Console.WriteLine(area != 0 ? $"area = {area}" : $"Couldn't calculate the area of the invalid {figure}");
    }
}
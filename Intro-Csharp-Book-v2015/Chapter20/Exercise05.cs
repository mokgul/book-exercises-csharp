namespace Chapter20;

public static class Exercise05
{
    public static void ShapesSurfaceAreas()
    {
        Shape[] shapes = new Shape[]
        {
            new Triangle(2 ,3),
            new Triangle(2 ,4),
            new Triangle(2 ,5),
            new Square(2 ,4),
            new Square(2 ,5),
            new Circle(3),
            new Circle(4)
        };
        
        double[] areas =  new double[shapes.Length];
        for (int i = 0; i < shapes.Length; i++)
        {
            Shape current = shapes[i];
            areas[i] = current.CalculateSurface();
        }
        
        Console.WriteLine(string.Join(", ", areas));
    }
    
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public virtual double CalculateSurface()
        {
            return 0;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(int width, int height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double result = Math.Round(Width * Height * 0.5, 2);
            return result;
        }
    }

    public class Square : Shape
    {
        public Square(int width, int height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double result = Math.Round(Width * Height * 1.0, 2);
            return result;
        }
    }

    public class Circle : Shape
    {
        public Circle(int radius) : base(radius, radius) { }

        public override double CalculateSurface()
        {
            double result = Math.Round(Math.PI * Math.Pow(Width, 2), 2);
            return result;
        }
    }
}
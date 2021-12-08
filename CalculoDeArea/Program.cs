using CalculoDeArea.Entities;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of shapes");
        int n = int.Parse(Console.ReadLine());
        List<Shape> shapes = new List<Shape>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Shape #{i + 1} :");
            Console.Write("Rectangle or Circle (r/c) ?");
            bool isRectangle = Console.ReadLine().Equals("r") ? true : false;
            Console.Write("Color (Black, Blue, Red)");
            Color color;
            Enum.TryParse<Color>(Console.ReadLine(), out color);
            double width, height;

            if (isRectangle)
            {
                Console.Write("Width:");
                width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Height:");
                height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                shapes.Add(new Rectangle(width, height));
            }
            else
            {
                Console.Write("Radius");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                shapes.Add(new Circle(radius));
            }
        }
        Console.WriteLine("shape Areas:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
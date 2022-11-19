using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    // Answer 10

    public interface IShape
    {
        double Perimeter();
        double Area();
    }

    public class Square : IShape
    {
        public int Length { get; set; }
        public double Area()
        {
            return Length * Length;
        }

        public double Perimeter()
        {
            return Length * 4;
        }
    }

    public class Circle : IShape
    {
        public int Radius { get; set; }
        public double Area()
        {
            return Radius * Radius * Math.PI;
        }

        public double Perimeter()
        {
            return Radius * Math.PI * 2;
        }
    }

    public class MainClass
    {
        public void Run()
        {
            Factory factory = new Factory();
            IShape shape = factory.NewShape(Console.ReadLine());
            if (shape != null)
            {
                int height = int.Parse(Console.ReadLine());
                Console.WriteLine("The volume is: " + Volume(shape, height));
            }
        }

        public double Volume(IShape shape, int height)
        {
            return shape.Area() * height;
        }
    }
    public class Factory
    {
        public IShape NewShape(string text)
        {
            IShape shape = null;
            if (text == "Square")
            {
                shape = new Square();
            }
            else if (text == "Circle")
            {
                shape = new Circle();
            }
            return shape;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    // Answer 9

    public class Polymorphism
    {
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
                IShape shape = new Square();
                Console.WriteLine(shape.Perimeter());
                Console.WriteLine(Volume(shape, 30));

                Circle c = new Circle();
                Console.WriteLine(Volume(c, 10));
            }

            public double Volume(IShape shape, int height)
            {
                return shape.Area() * height;
            }
        }
    }
}

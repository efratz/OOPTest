using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    // Answer 6

    public abstract class AbstractClass
    {
        public abstract string GetObject();
    }

    public class Boy : AbstractClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string GetObject()
        {
            return "Boy";
        }
    }

    public class Product : AbstractClass
    {
        public double Price { get; set; }
        public override string GetObject()
        {
            return "Product";
        }
    }

    public class Main
    {
        public void Run()
        {
            AbstractClass a = new Boy();
            AbstractClass b = new Product();

            Console.WriteLine(a.GetObject() + " " + b.GetObject());
        }
    }
}

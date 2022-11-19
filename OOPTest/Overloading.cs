using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    // Answer 8

    public class Overloading
    {
        public void Run()
        {

        }

        public void Run(int id)
        {

        }

        public void Run(int id, string text)
        {

        }
    }

    public class ClassExaple
    {
        public void Start()
        {
            Overloading x = new Overloading();
            x.Run();
            x.Run(100);
            x.Run(1, "text");
        }
    }
}

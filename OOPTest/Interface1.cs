using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    // Answer 7

    public interface IPerson
    {
        void Eat();
        string ToSay();
    }

    public class Girl : IPerson
    {
        public string Name { get; set; }

        public void Eat()
        {

        }

        public string ToSay()
        {
            return "bye-bye";
        }
    }

    public class Baby : IPerson
    {
        public string Name { get; set; }

        public void Eat()
        {
        }

        public string ToSay()
        {
            return "Grrr";
        }
    }


    public class MainInterface
    {
        public void Run()
        {
            Girl girl = new Girl();
            girl.Name = "Mimi";
            Console.WriteLine(GetDetails(girl));
            IPerson p = girl;
            Console.WriteLine(p.ToSay());

            IPerson p2 = new Baby();
            Console.WriteLine(GetDetails(p2));
        }

        public string GetDetails(IPerson p)
        {
            return p.ToSay();
        }

    }
}

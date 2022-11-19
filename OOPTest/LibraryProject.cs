using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    // Answer 11

    public class TheLibrary { 
        public TheLibrary() { FactoryToLibrary factoryToLibrary = new FactoryToLibrary(); } 
    }

    public abstract class Person { string id; string name; string phone; }
    public class Customer : Person { int childNum; string address; Fine fine; }
    public class Author : Person { }

    public interface IEmployee { Salary GetSalary(); }
    public abstract class Employee : Person, IEmployee { public abstract Salary GetSalary(); }
    public class Librarian : Employee { public override Salary GetSalary() { return new Salary(this); } }
    public class Cleaner : Employee { public override Salary GetSalary() { return new Salary(this); } }
    public class Supplier : Employee { public override Salary GetSalary() { return new Salary(this); } }

    public class BookCategory { }
    public class Book { int id; BookCategory bookCategory; Author author; string bookName; }
    public class CopyBook : Book { int copyNum; }
    public class StockManager { Book book; int copiesNumber; }
    public class OrderingBooks { Supplier supplier; Dictionary<Book, int> books; }


    public class Lending { DateTime start, end; Subscription subscription; CopyBook book; Fine fine; }
    public class Subscription { Customer customer; }
    public class Fine { }

    public class FinancialManager { private static double SAFE; }
    public class OrganizeTheBooks { CopyBook[] copyBooks; }
    public class Salary { double money; string file; public Salary(IEmployee employee) {  } }


    public class FactoryToLibrary
    {
        public FactoryToLibrary() 
        {
            // Create all the objests
            
        }
    }    
}

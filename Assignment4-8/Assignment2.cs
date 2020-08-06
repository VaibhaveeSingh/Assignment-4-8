using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_8
{
    class Person {
        int age;
        string fname;
        string lname;
        string city;

        public Person()
        {

        }

        public Person(int _age,string _fname,string _lname,string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;
        }

        public void DisplayClass() {
            Console.WriteLine("PERSONAL DETAILS......");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Full Name: {0} {1}", fname, lname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("City: {0}", city);
        }

    }
    class Assignment2
    {
        static void Main() 
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { 12, "Billy","Eilish","L.A"});

        }
    }
}

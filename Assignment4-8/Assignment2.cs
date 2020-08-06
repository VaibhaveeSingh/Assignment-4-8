using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Assignment4_8
{
    class Person {
       
        
        public int age { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string city { get; set; }
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
        
        public void DisplayPerson() {
            Console.WriteLine("PERSONAL DETAILS......");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Full Name: {0} {1}", fname, lname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("City: {0}", city);
            Console.WriteLine("____________________________________________");
        }

    }
    class Assignment2
    {
        static void Main() 
        {
           
            

            var listPerson = new List<Person>
            {
                new Person(12, "Billy","Eilish","L.A"),
                new Person(30, "Taylor","Swift","L.A"),
                new Person(12, "Bruno","Mars","L.A"),
                new Person(12, "Daisy","Swish","L.A")
            };
            List<Person> people = new List<Person>(listPerson);

            

            foreach (Person item in people)
            {
                item.DisplayPerson();
                

            }
            

        }
    }
}

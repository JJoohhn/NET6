using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Person
    {
        //konstruktory
        //proprty
        //metody

        public Person()
        {
            FirstName = "nezadano";
            LastName = "nezadano";
            //Age = 0;
        }

        
        
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            //Age = age;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Address HomeAddress { get; set; }

        public DateTime DateOfBirth { get; set; }

        //public int Age()
        //{
        //    return DateTime.Now.Year - DateOfBirth.Year;
        //}

        public string GetFullName()
        {
            return FirstName + " " + LastName; 
        }

        //Přepsání metody ToString
        public override string ToString()
        {
            return GetFullName();
        }

        

        // Třída je obecná šablona, podle které se vytváří konkrétní objekty.
    }
}

using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company ACME = new Company("ACME", new DateTime(2000, 12, 31));

            // Create three employees
            Employee Ashley = new Employee()
            {
                FirstName = "Ashley",
                LastName = "Taylor",
                Title = "Copier",
                StartDate = new DateTime(2012, 2, 2),
            };

            Employee Theo = new Employee()
            {
                FirstName = "Theo",
                LastName = "Thistle",
                Title = "Farmer",
                StartDate = new DateTime(2011, 1, 2),
            };

            Employee Person = new Employee()
            {
                FirstName = "Human",
                LastName = "Being",
                Title = "Existing",
                StartDate = new DateTime(2001, 12, 2),
            };


            // Assign the employees to the company
            ACME.CurrentEmployees = new List<Employee>() { Ashley, Theo, Person };
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            //forEach  loop are for List
            //same as for of in JavaScript
            foreach (Employee person in ACME.CurrentEmployees)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} works for {ACME.Name} as {person.Title} since {person.StartDate} ");
            }
        }
    }
}

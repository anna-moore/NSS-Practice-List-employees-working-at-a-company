using System;
public class Company
{

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<string> CurrentEmployees = new List<string>()
    {
        "bowling", "jumping on the bed", "sword swallowing"
    };
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */

    public Company(string nameOfCompany, DateTime dateOfEstablishment)
    {

    }
}
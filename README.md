# NSS-Practice-List-employees-working-at-a-company

## Instructions
1. Expand on the `Company` class code by
    1. Adding an **Employees** property (Its type should be **`List<Employee>`**)
    1. Setting the value of **Employees** in the constructor as a `new List<Employee>` (News Flash: Declaring a property gives it an initial vlaue of `null`). This will allow you to add newly created employees to the Employees list in the final step below.
1. Create an `Employee.cs` file and then define a class for `Employee`. An employee has the following properties.
    1. First name (_string_)
    1. Last name (_string_)
    1. Title (_string_)
    1. Start date (_DateTime_)
1. The `Company` class should also have a `ListEmployees()` method which outputs a string about each employee, such as _"Jane Doe works for Acme, Inc. as Lion Tamer since 3/23/15."_
1. In the `Main` method of your console application, create a new instance of Company, and three instances of Employee. Then assign the employees to the company.

using System;

public class Program
{
    public static void Main()
    {
        Employee emp1 = new Employee
        {
            FirstName = "Ichigo",
            LastName = "Kurosaki",
            Salary = 20000,
            yearOfService = 3
        };

        Console.WriteLine(emp1.getFullName());
    }
}

public class Employee
{
    public string FirstName;
    public string LastName;
    public int Salary;
    public int yearOfService;

    public string getFullName()
    {
        return FirstName + " " + LastName;
    }
}

public class Circle{
    public float Pi=3.14F; 
}
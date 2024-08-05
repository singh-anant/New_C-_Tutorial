using System;

namespace Polymorphism_Tutorial
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void PrintFullName()
        {
            Console.WriteLine($"Name of Employee is: {FirstName} {LastName}");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
        public override void PrintFullName(){
            base.PrintFullName();
        }
    }
    public class Trainee : Employee
    {
        public Trainee(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
        public override void PrintFullName(){
            base.PrintFullName();
        }
    }
public class Contractor : Employee
    {
        public Contractor(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
        public override void PrintFullName(){
            base.PrintFullName();
        }
    }
}
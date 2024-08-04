using System;
using Classes_Tutorial;

public class Program
{
    public static void Main()
    {
        // Employee emp1 = new Employee
        // {
        //     FirstName = "Ichigo",
        //     LastName = "Kurosaki",
        //     Salary = 20000,
        //     yearOfService = 3
        // };

        // Console.WriteLine(emp1.getFullName());

        Car cr=new Car(Make:"Kia",Model:"Sonet");
        // cr.Make="Hundai";
        // cr.Model="I20";
        cr.PrintCarName();
        cr.PrintValueOfObject(cr);

      System.Console.WriteLine(new Circle(31.4F).GetAreaOfCircle());


      Employee employee=new Employee(){
        empId=2,
        FirstName="Naruto",
        LastName="Uzumaki",  
        Salary=20000,
        yearOfService=3
        };
        employee.getFullName();
      }

    
}
//now lets say we wnat that cannot be negative,First and Last name cannot be
//  null and salary must be less than 100000;
// yearOfService >=0...These aree some business rules....
public class Employee
{
    private int _empId;
    private string _FirstName;
    private string _LastName;
    private int _Salary;
    private int _yearOfService;

    public int empId
    {
        set
        {
            if (value > 0)
                _empId = value;
            else
                throw new Exception("Id cannot be negative");
        }
        get
        {
            return _empId;
        }
    }

    public string FirstName
    {
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("FirstName cannot be null or empty");
            else
                _FirstName = value;
        }
        get
        {
            return _FirstName;
        }
    }

    public int Salary
    {
        set
        {
            if (value <= 100000)
                _Salary = value;
            else
                throw new Exception("Salary cannot be more than 100000");
        }
        get
        {
            return _Salary;
        }
    }

    public string LastName
    {
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("LastName cannot be null or empty");
            else
                _LastName = value;
        }
        get
        {
            return _LastName;
        }
    }

    public int yearOfService
    {
        set
        {
            if (value > 0)
                _yearOfService = value;
            else
                throw new Exception("Years of service cannot be negative");
        }
        get
        {
            return _yearOfService;
        }
    }

    public string getFullName()
    {
        return FirstName + " " + LastName;
    }
}


public class Circle{
    //we cannot access static members with the instance of class..
    public static float Pi=3.14F; 
    public float Radius;

     public Circle(float Radius){
         this.Radius=Radius;
     }

    public float GetAreaOfCircle(){
        return Pi*Radius*Radius;
    }
}
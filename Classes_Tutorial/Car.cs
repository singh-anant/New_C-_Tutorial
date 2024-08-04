using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_Tutorial
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public Car(){
            Make = "Unknown Make";
            Model="Unknown Model";
        }

        public Car(string Make,string Model){
            this.Make = Make;
            this.Model = Model;
        }

        public void PrintValueOfObject(Car cr){
            System.Console.WriteLine(cr);
        }

        public void PrintCarName(){
            System.Console.WriteLine($"This is a {Make} {Model}");
        }

    }
}
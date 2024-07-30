namespace Methods_Tutorial
{
    internal class Program{
        static void Main(string[] args){
            System.Console.WriteLine("Hello World");
            //call instance method...
            new Program().PrintCurrentYear();

            //call static method....

            Program.PrintCurrentDate();
            System.Console.WriteLine(new Program().CalculateAreaOfRectangle(length:21.22,breadth:23.12));
            int j=20;
            //just like call by value...

            new Program().ValueParameterExplained(j);
            System.Console.WriteLine($"Value of J is {j}");

            //here we are using ref to make j as reference parameter...
            new Program().ReferenceParameterExplained(ref j);
            System.Console.WriteLine($"Value of J is {j}");

            new Program().GetSquareAndCubeOfANumber(5,out int squareResult,out int cubeResult);
            System.Console.WriteLine(squareResult);
            System.Console.WriteLine(cubeResult);
            System.Console.WriteLine(new Program().multiplyNumbers(2));
        }

        public void PrintCurrentYear(){
            
            DateTime currentDateTime=DateTime.Now;
            int currentYear=currentDateTime.Year;
            System.Console.WriteLine(currentYear);
        }

        public static void PrintCurrentDate(){
            DateTime currentDateTime=DateTime.Now;
            System.Console.WriteLine(currentDateTime.Date);
        }

        public double CalculateAreaOfRectangle(double length,double breadth){
            return length*breadth;
        }

        public void ValueParameterExplained(int j){
            j++;
        }

        public void ReferenceParameterExplained(ref int j){
            j++;
        }
//what if we want to return nmore than oen value...
        public void GetSquareAndCubeOfANumber(int number,out int square,out int cube){
             square=number*number;
             cube=number*number*number;            
        }

        public int multiplyNumbers(int requiredParameter,int optionalParameter1=10,int optionalParameter2=10){
            return optionalParameter1*optionalParameter2*requiredParameter;
        }
    }
}
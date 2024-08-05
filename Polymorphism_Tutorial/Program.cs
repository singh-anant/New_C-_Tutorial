using Polymorphism_Tutorial;

class Program{
    public static void Main() {
         

         
             // Create instances of each employee type
            Employee[] employees = new Employee[5];

            // Populate the array with different types of employees
            employees[0] = new FullTimeEmployee("Naruto", "Uzumaki");
            employees[1] = new Trainee("Sasuke", "Uchiha");
            employees[2] = new Contractor("Sakura", "Haruno");
            employees[3] = new FullTimeEmployee("Kakashi", "Hatake");
            employees[4] = new Trainee("Shikamaru", "Nara");

       

        foreach (Employee emp in employees)
        {
            emp.PrintFullName();
        }

        

          
     
        
    }
}
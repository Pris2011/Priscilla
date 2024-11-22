 using System;

    class EmpDashboard : EmpLogin
    {
       public string Name {get; set; }
      
       public string MailId { get ; set; }
       public string Position { get; set; }

       public string City {get ; set ;}

       public string State {get ; set ;}
      
       public double Salary { get; set;}
       
       public void DisplayDetails()
       {
           Console.WriteLine("\n-----Employee Details Below------");

           
           Console.WriteLine("Name of the employee: " + Name);
           Console.WriteLine("Employee MailId: " + MailId);
           Console.WriteLine("Employee Position: " + Position);
           Console.WriteLine("Employee City: " + City);
           Console.WriteLine("Employee State: " + State);
           Console.WriteLine("Employee Salary: " + Salary.ToString("C"));
           
           
       }
    }
    

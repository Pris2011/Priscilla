using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EmpDashboard> employees = new List<EmpDashboard>();

            EmpLogin admin = new EmpLogin { Username = "admin", Password = "Admin@123" };


            Console.WriteLine("**** Employee Management System ***");
            Console.Write("Enter username: ");

            string username = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(username))
           {
            Console.WriteLine("Username cannot be empty.");
            return;
           }

            if (username.Length < 5)
            {
                Console.WriteLine("Username must be at least 5 characters long.");
                return;
            }

        
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Password cannot be empty.");
                return;
            }

            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long.");
                return;
            }

            bool hasUppercase = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUppercase = true;
                    break;
                }
            }

            if (!hasUppercase)
            {
                Console.WriteLine("Password must contain at least one uppercase letter.");
                return;
            }

            bool hasNumber = false;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    hasNumber = true;
                    break;
                }
            }

            if (!hasNumber)
            {
                Console.WriteLine("Password must contain at least one number.");
                return;
            }

            bool hasSpecialChar = false;
            string specialChars = "!@#$%^&*(),.?\":{}|<>"; // List of common special characters
            foreach (char c in password)
            {
                if (specialChars.Contains(c))
                {
                    hasSpecialChar = true;
                    break;
                }
            }

            if (!hasSpecialChar)
            {
                Console.WriteLine("Password must contain at least one special character.");
                return;
            }

            Console.WriteLine("Username and password are valid.");

                if (admin.Login(username, password))
                {
                    Console.WriteLine("\nLogin successful!");
                    while (true)
                    {
                        Console.WriteLine("\nMenu:");
                        Console.WriteLine("1. Add new Employee");
                        Console.WriteLine("2. Display the Employee details");
                        Console.WriteLine("3. Exit the application");
                        Console.Write("Enter your choice: ");
                        int choice = Convert.ToInt32(Console.ReadLine()); 

                        switch (choice)
                        {
                            case 1:
                                EmpDashboard emp = new EmpDashboard();
                                Console.Write("Enter Name: ");
                                emp.Name = Console.ReadLine();

                                
                                Console.Write("Enter Mail ID: ");
                                emp.MailId = Console.ReadLine();
                                Console.Write("Enter City: ");
                                emp.City = Console.ReadLine();
                                Console.Write("Enter State: ");
                                emp.State = Console.ReadLine();
                                Console.Write("Enter Position: ");
                                emp.Position = Console.ReadLine();
                                Console.Write("Enter Salary: ");
                                emp.Salary = Convert.ToDouble(Console.ReadLine());
                                employees.Add(emp);
                                Console.WriteLine("Employee added successfully!");
                                break;


                            case 2:
                                if (employees.Count > 0)
                                {
                                    foreach (var employee in employees)
                                    {
                                        employee.DisplayDetails();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No employees to display.");
                                }
                                break;

                            case 3:
                                Console.WriteLine("Exiting the application.");
                                return;

                            default:
                                Console.WriteLine("Invalid choice! Try again.");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid login credentials. Exiting...");
                }
            }
        }
    }

        
    
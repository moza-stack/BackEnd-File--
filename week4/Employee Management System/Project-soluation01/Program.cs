

#region OOP Practical Task 

using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem
{
    
    // Base Class: Employee
    
    class Employee
    {
        // Private Fields
        private int id;
        private double salary;

        // Public Properties with Validation
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
                else
                    Console.WriteLine("Invalid ID. ID must be greater than 0");
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    Console.WriteLine("Invalid Salary. Salary cannot be negative");
            }
        }

        // Additional Public Properties
        public string Name { get; set; }
        public string Department { get; set; }

        // Constructor
        public Employee(int id, string name, string department, double salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        // Virtual Method
        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }
    }

  
    // Derived Class: Developer
    
    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(
            int id,
            string name,
            string department,
            double salary,
            string programmingLanguage)
            : base(id, name, department, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        // Override Method
        public override void Work()
        {
            Console.WriteLine("Developer is writing code");
        }
    }

    
    // Derived Class: Designer
    
    class Designer : Employee
    {
        public string DesignTool { get; set; }

        public Designer(
            int id,
            string name,
            string department,
            double salary,
            string designTool)
            : base(id, name, department, salary)
        {
            DesignTool = designTool;
        }

        // Override Method
        public override void Work()
        {
            Console.WriteLine("Designer is creating UI designs");
        }
    }

    
    // Employee Manager Class
    
    class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        // Add Employee
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        // Display All Employees
        public void ShowAllEmployees()
        {
            foreach (Employee employee in employees)
            {
                employee.Work();
            }
        }
    }

    
    // Main Program
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Manager Object
            EmployeeManager manager = new EmployeeManager();

            // Create Objects
            Developer developer1 = new Developer(
                1,
                "Moza",
                "Engineering",
                150,
                "C#"
            );

            Designer designer1 = new Designer(
                2,
                "Saja",
                "UI/UX",
                1200,
                "Figma"
            );

            // Add Employees
            manager.AddEmployee(developer1);
            manager.AddEmployee(designer1);

            // Display Employees
            manager.ShowAllEmployees();

#endregion
        }
    }
}
/*
 * Author: Jack Flenniken
 * Date: 11/7/2025
 * Purpose: Use chatgpt to complete task6
 * Prompts i used:
 * - Give me the code in csharp for the different classes using the resources pasted below: (inserted the tables from task6)
 * - Below is the code I have make something pasteable into that: namespace Task6GPT { internal class Program { static void Main(string[] args) { Console.WriteLine("Hello, World!"); } } }
 * - Then pasted into the code editor
 */

using System;

namespace Task6GPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Car
            Car car1 = new Car("Toyota", "Camry", 2020);
            car1.DisplayInfo();

            Car car2 = new Car("Ford", "F-150");
            car2.DisplayInfo();

            // Test Employee
            Employee emp1 = new Employee("Alice", 25.0, 40);
            emp1.DisplaySummary();

            Employee emp2 = new Employee("Bob");
            emp2.DisplaySummary();

            // Test Account
            Account acc1 = new Account(12345, "Alice", 500.0);
            acc1.Deposit(200);
            acc1.Withdraw(100);
            acc1.DisplayInfo();

            Account acc2 = new Account(67890, "Bob");
            acc2.Deposit(50);
            acc2.DisplayInfo();
        }
    }

    public class Car
    {
        private string make;
        private string model;
        private int year;

        public Car()
        {
            make = "Generic";
            model = "Car";
            year = DateTime.Now.Year;
        }

        public Car(string make, string model)
        {
            this.make = make;
            this.model = model;
            this.year = DateTime.Now.Year;
        }

        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = (year >= 1886 && year <= DateTime.Now.Year) ? year : DateTime.Now.Year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {year} {make} {model}");
        }
    }

    public class Employee
    {
        private string name;
        private double hourlyRate;
        private int hoursPerWeek;

        public Employee()
        {
            name = "New Hire";
            hourlyRate = 15.0;
            hoursPerWeek = 40;
        }

        public Employee(string name)
        {
            this.name = name;
            hourlyRate = 15.0;
            hoursPerWeek = 40;
        }

        public Employee(string name, double rate, int hours)
        {
            this.name = name;
            this.hourlyRate = rate > 0 ? rate : 15.0;
            this.hoursPerWeek = (hours >= 0 && hours <= 80) ? hours : 40;
        }

        public double AnnualSalary()
        {
            return hourlyRate * hoursPerWeek * 52;
        }

        public void DisplaySummary()
        {
            Console.WriteLine($"Employee: {name}, Annual Salary: ${AnnualSalary():F2}");
        }
    }

    public class Account
    {
        private int accountNumber;
        private string ownerName;
        private double balance;

        public Account()
        {
            accountNumber = 0;
            ownerName = "Unknown";
            balance = 0.0;
        }

        public Account(int number, string owner)
        {
            accountNumber = number;
            ownerName = owner;
            balance = 0.0;
        }

        public Account(int number, string owner, double balance)
        {
            accountNumber = number;
            ownerName = owner;
            this.balance = balance >= 0 ? balance : 0.0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Account #{accountNumber}, Owner: {ownerName}, Balance: ${balance:F2}");
        }
    }
}
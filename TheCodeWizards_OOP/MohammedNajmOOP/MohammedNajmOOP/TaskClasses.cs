using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohammedNajmOOP
{
    internal class TaskClasses
    {
    }
    //--------------------------------------------------------------------------------------------------------------
    //Exercise 1: Create a Car class with attributes brand, model, and year. Add methods start() and stop(). Create 3 car objects and call their methods.
    class Car
    {
        // Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Constructor
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        // Methods
        public void Start()
        {
            Console.WriteLine($"{Brand} {Model} ({Year}) is starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} {Model} ({Year}) is stopping...");
        }
    }
    //--------------------------------------------------------------------------------------------------------------
    //Exercise 2: Create a Student class with attributes name, age, and grade. Add a method introduce() that prints the student details.
    class Student
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        // Constructor
        public Student(string name, int age, string grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        // Method to introduce the student
        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name}, I am {Age} years old and I am in grade {Grade}.");
        }
    }
    //--------------------------------------------------------------------------------------------------------------
    //Exercise 3: Create a Rectangle class with attributes width and height. Add methods area() and perimeter() to calculate and return the values.
    public class Rectangle
    {
        // الخصائص
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // دالة لحساب المساحة
        public double Area()
        {
            return Width * Height;
        }

        // دالة لحساب المحيط
        public double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
    //--------------------------------------------------------------------------------------------------------------
    //Exercise 4: Create a BankAccount class with attributes account_number and balance. Add methods deposit(amount), withdraw(amount), and check_balance().
    public class BankAccount
    {
        // الخصائص
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, decimal initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        // دالة الإيداع
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // دالة السحب
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be positive.");
            }
            else if (amount > Balance)
            {
                // سحب أكبر من الرصيد
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. New Balance: {Balance:C}");
            }
        }

        // دالة عرض الرصيد
        public void CheckBalance()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Current Balance: {Balance:C}");
        }
    }

}

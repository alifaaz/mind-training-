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
    //Exercise 2:


}

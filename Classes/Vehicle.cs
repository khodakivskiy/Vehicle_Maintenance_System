using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05.Classes
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        protected string Manufacturer { get; set; }
        protected int Year { get; set; }

        public Vehicle(string model, string manufacturer, int year)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
        }
        public abstract void DisplayInfo();
        public virtual void StartEngine()
        {
            Console.WriteLine("Двигун запущено");
        }
    }
}

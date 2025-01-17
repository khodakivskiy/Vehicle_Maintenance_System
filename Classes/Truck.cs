using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05.Classes
{
    public class Truck : Vehicle
    {
        protected double LoadCapacity {  get; set; }
        public Truck(string model, string manufacturer, int year, double loadCapacity) : base(model, manufacturer, year) 
        {
        LoadCapacity = loadCapacity;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Модель: {Model}. Виробник: {Manufacturer}. Рік: {Year}. Вантажопідйомність у тонах: {LoadCapacity}. Тип: ВАНТАЖІВКА.");
        }
        public override void StartEngine()
        {
            Console.WriteLine("Двигун вантажівки запущено.");
        }
    }
}

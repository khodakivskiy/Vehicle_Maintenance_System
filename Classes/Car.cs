using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Sana05.Classes
{
    public class Car : Vehicle
    {
        protected int SeatCount { get; set; }
        public Car(string model, string manufacturer, int year, int seatCount) : base(model, manufacturer, year) 
        { 
            SeatCount = seatCount;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Модель: {Model}. Виробник: {Manufacturer}. Рік: {Year}. К-сть місць: {SeatCount}. Тип: АВТОМОБІЛЬ.");
        }
        public override void StartEngine()
        {
            Console.WriteLine("Двигун автомобіля запущено.");
        }
    }
}

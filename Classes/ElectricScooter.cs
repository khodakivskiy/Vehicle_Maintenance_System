using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05.Classes
{
    public class ElectricScooter : Vehicle
    {
        protected double BatteryCapacity { get; set; }
        public ElectricScooter(string model, string manufacturer, int year, double batteryCapacity) : base(model, manufacturer, year)
        {
            BatteryCapacity = batteryCapacity;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Модель: {Model}. Виробник: {Manufacturer}. Рік: {Year}. Ємність батареї в кВт·год: {BatteryCapacity}. Тип: ЕЛЕКТРОСАМОКАТ.");
        }
        public override void StartEngine()
        {
            Console.WriteLine("Двигун вантажівки запущено.");
        }
    }
}

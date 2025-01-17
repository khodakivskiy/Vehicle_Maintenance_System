using Sana05.Interfaces;
using Sana05.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05.Classes
{
    public class Truck : Vehicle, IMaintainable
    {
        protected double LoadCapacity {  get; set; }
        public MaintenanceInfo? maintenanceInfo { get; private set; }
        public bool IsUnderMaintenance { get; private set; }

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
            Console.WriteLine($"Двигун вантажівки {Model} запущено.");
        }

        public void ScheduleMaintenance(DateTime date)
        {
            maintenanceInfo = new MaintenanceInfo(date, "Петро");
            IsUnderMaintenance = true;
            Console.WriteLine($"Обслуговування {Model} заплановано на {maintenanceInfo.ScheduledDate.ToShortDateString()}, технік: {maintenanceInfo.Technician}");
        }
        public void GetFullInfoAboutMaintenance()
        {
            if (maintenanceInfo != null)
            {
                Console.WriteLine($"   Обслуговування {Model} заплановано на {maintenanceInfo.ScheduledDate.ToShortDateString()}, технік: {maintenanceInfo.Technician}");
            }
            else Console.WriteLine($"   Для {Model} немає запланованого обслуговування.");
        }
    }
}

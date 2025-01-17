using Sana05.Interfaces;
using Sana05.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Sana05.Classes
{
    public class Car : Vehicle, IMaintainable
    {
        protected int SeatCount { get; set; }
        public MaintenanceInfo? maintenanceInfo { get; private set; }
        public bool IsUnderMaintenance { get; private set; }

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
            Console.WriteLine($"Двигун автомобіля {Model} запущено.");
        }

        public void ScheduleMaintenance(DateTime date)
        {
            maintenanceInfo = new MaintenanceInfo(date, "Олег");
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

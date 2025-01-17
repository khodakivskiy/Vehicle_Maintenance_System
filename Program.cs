using Sana05.Classes;
using Sana05.Interfaces;
using Sana05.Records;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<Vehicle> vehicles= new List<Vehicle>();
vehicles.Add(new Car("Model S", "Tesla", 2022, 5));
vehicles.Add(new Car("M5 F90", "BMW", 2018, 5));
vehicles.Add(new Car("S7", "Audi", 2020, 2));
vehicles.Add(new Truck("Actros", "Mercedes-Benz", 2020, 18.0));
vehicles.Add(new ElectricScooter("Xiaomi M365", "Xiaomi", 2021, 30.0));

int iter = 0;
while (true)
{
    if (iter > 0)
    {
        Console.WriteLine("\n");
    }
    bool isOk;
    Console.WriteLine("Ви знаходитесь у головному меню:");
    Console.WriteLine("1. Показати список транспортних засобів");
    Console.WriteLine("2. Запустити двигун вибраного транспортного засобу");
    Console.WriteLine("3. Додати інформацію про обслуговування");
    Console.WriteLine("4. Показати транспортні засоби, які знаходяться на обслуговуванні");
    Console.WriteLine("5. Вихід");
    Console.Write("Виберіть опцію: ");
    int menu;
    do {
        isOk = int.TryParse(Console.ReadLine(), out menu);
        if (!isOk)
        {
            Console.WriteLine("Введіть вірне значення!");
        }
    }while(!isOk);

    switch (menu)
    {
        case 1: 
            ShowVehicles(vehicles);
            break;
        case 2:
            EngineStart(vehicles);
            break;
        case 3:
            AddMaintenanceInfo(vehicles);
            break;
        case 4:
            ShowUnderMaintenance(vehicles);
            break;
        case 5:
            Console.WriteLine("Вихід з програми...");
            return 0;
        default: 
            Console.WriteLine("Такий пункт меню - відсутній");
            break;
    }
    iter++;
}

static void ShowVehicles(List<Vehicle> vehicles)
{
    Console.WriteLine("\nСписок транспортних засобів:");
    int i = 1;
    foreach(Vehicle vehicle in vehicles)
    {
        Console.Write($"{i}) ");
        vehicle.DisplayInfo();
        i++;
    }
}
static void EngineStart(List<Vehicle> vehicles)
{
    Console.Write("Введіть номер транспортного засобу для запуску двигуна: ");
    int index = int.Parse(Console.ReadLine()) - 1;
    if (index >= 0 && index < vehicles.Count)
    {
        vehicles[index].StartEngine();
    }
    else Console.WriteLine("Такого ТЗ не існує");
}
static void AddMaintenanceInfo(List<Vehicle> vehicles)
{
    Console.Write("Введіть номер транспортного засобу для обслуговування: ");
    int index = int.Parse(Console.ReadLine()) - 1;
    if (index >= 0 && index < vehicles.Count)
    {
        if (vehicles[index] is IMaintainable maintainable)
        {
            Console.Write("Введіть дату обслуговування (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                maintainable.ScheduleMaintenance(date);
            }
            else throw new Exception("Unknown date");
        }
        else Console.WriteLine("Такий транспорт не обслуговується");
    }
    else Console.WriteLine("Такого ТЗ не існує");
}
static void ShowUnderMaintenance(List<Vehicle> vehicles)
{
    Console.WriteLine("Транспорт, який знаходиться на обслуговуванні:");
    int i = 0;
    foreach (Vehicle vehicle in vehicles)
    {
        if (vehicle is IMaintainable maintainable && maintainable.IsUnderMaintenance)
        {   
            i++;
            Console.Write($"{i}) ");
            vehicle.DisplayInfo();
            maintainable.GetFullInfoAboutMaintenance();
        }
    }
}
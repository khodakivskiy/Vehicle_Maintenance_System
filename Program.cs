using Sana05.Classes;

List<Vehicle> vehicles= new List<Vehicle>();
vehicles.Add(new Car("Model S", "Tesla", 2022, 5));
vehicles.Add(new Car("M5 F90", "BMW", 2018, 5));
vehicles.Add(new Car("S7", "Audi", 2020, 2));
vehicles.Add(new Truck("Actros", "Mercedes-Benz", 2020, 18.0));
vehicles.Add(new ElectricScooter("Xiaomi M365", "Xiaomi", 2021, 30.0));

int ProgramWork = 0;
do
{
   
    Console.WriteLine("ВИ ЗНАХОДИТЕСЬ В ГОЛОВНОМУ МЕНЮ: 1)Показати список транспортних засобів.\r\n2)Запустити двигун вибраного транспортного засобу.\r\n3)Додати інформацію про обслуговування.\r\n4)Показати транспортні засоби, які знаходяться на обслуговуванні.\r\n ");


    Console.WriteLine("Введіть значення 0 д): ");
    ProgramWork = int.Parse(Console.ReadLine());
} while (ProgramWork != 0); 
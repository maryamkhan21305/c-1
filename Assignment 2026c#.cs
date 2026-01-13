//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using taxManagement;

Car car1 = new Car(101, "City", "KHI-1122", "Honda", 3, "Car");
car1.PayTax((int)car1.BasePrice);

Car car2 = new Car(102, "Altis", "LHR-3344", "Toyota", 3, "Car");
car2.PayTax((int)car2.BasePrice);

Car car3 = new Car(103, "Camry", "ISB-5566", "Toyota", 4, "Car");
car3.PayTax((int)car3.BasePrice);

Car car4 = new Car(104, "Baleno", "KHI-7788", "Suzuki", 2, "Car");
car4.PayTaxPassWithoutPaying();

Car car5 = new Car(105, "Mustang GT", "LHR-9900", "Ford", 5, "Car");
car5.PayTaxPassWithoutPaying();

Bike bike1 = new Bike(201, "CG 125", "KHI-1111", "Honda", 1, "Bike");
bike1.PayTax((int)bike1.BasePrice);

Bike bike2 = new Bike(202, "R15 V3", "LHR-2222", "Yamaha", 1, "Bike");
bike2.PayTax((int)bike2.BasePrice);

Bike bike3 = new Bike(203, "KTM RC 200", "ISB-3333", "KTM", 1, "Bike");
bike3.PayTaxPassWithoutPaying();

HeavyCar hc1 = new HeavyCar(301, "Actros 2546", "TRK-1122", "Mercedes-Benz", 6, "HeavyCar");
hc1.PayTax((int)hc1.BasePrice);

HeavyCar hc2 = new HeavyCar(302, "FMX 500", "TRK-3344", "Volvo", 6, "HeavyCar");
hc2.PayTaxPassWithoutPaying();

HeavyCar hc3 = new HeavyCar(303, "Prima LX 12", "TRK-5566", "Tata", 6, "HeavyCar");
hc3.PayTax((int)hc3.BasePrice);

Console.WriteLine("Total Tax Collection: RS " + ToolVehicle.TotalTaxCollected);
Console.WriteLine("Total Tax Pay Vehicles: " + ToolVehicle.TotalTaxPayingVehicles);
Console.WriteLine("Total NO Tax Pay Vehicles: " + ToolVehicle.TotalNonTaxPayingVehicles);
Console.WriteLine("Total Vehicle Entry: " + ToolVehicle.TotalVehicles);

namespace autoservisObjmd
{
    /// <summary>
    /// Main 'Program.cs' class where all used Classes are defined as
    /// objects for further actions.
    /// Simple LINQ queries to represent object relations.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the program.
        /// </summary>
        static void Main(string[] args)
        {

            Owner serviceOwnerPraha = new Owner("Pavel", "Prazak", "Na kopeckach 124, Praha 5, 158 00");
            Owner serviceOwnerPlzen = new Owner("Martin", "Moravak", "U Vilema 29, Plzen, 301 00");
            Owner serviceOwnerBrno = new Owner("Vojtech", "Vidlicka", "Metropolitanska 10, Brno, 616 00");

            CarService servicePraha = new CarService("ZZZ Auto Praha", serviceOwnerPraha, "Pleskova 42, Praha 5, 158 00");
            CarService servicePlzen = new CarService("ZZZ Auto Plzen", serviceOwnerPlzen, "Radlicka 99, Plzen, 302 00");
            CarService serviceBrno = new CarService("ZZZ Auto Brno", serviceOwnerBrno, "Martinska 204, Brno, 613 00");

            List<CarService> carServices = new List<CarService>()
            {
                servicePraha, servicePlzen, serviceBrno
            };

            Employee employeePraha1 = new Employee("Martin", "Petr", "Technik", true);
            Employee employeePraha2 = new Employee("Ales", "Paca", "Inspekce", false);
            Employee employeePraha3 = new Employee("Pavel", "Krystal", "Technik", false);

            servicePraha.AddEmployee(employeePraha1);
            servicePraha.AddEmployee(employeePraha2);
            servicePraha.AddEmployee(employeePraha3);
            servicePraha.PrintEmployees();

            Employee employeePlzen1 = new Employee("Vojtech", "Petr", "Technik", true);
            Employee employeePlzen2 = new Employee("Ales", "Paca", "Inspekce", false);

            servicePlzen.AddEmployee(employeePlzen1);
            servicePlzen.AddEmployee(employeePlzen2);

            Employee employeeBrno1 = new Employee("Pavel", "Martin", "Technik", true);

            serviceBrno.AddEmployee(employeeBrno1);

            Client clientPraha1 = new Client("Alexey", "Ivanov", "775 843 203", "ivanov@gmail.com");
            Client clientPraha2 = new Client("Zdenek", "Prokop", "775 343 840", "prokopzdena@center.cz");

            Client clientPlzen1 = new Client("Libor", "Libovy", "775 343 840", "libovy334@center.cz");

            Client clientBrno1 = new Client("Martin", "Rebel", "773 343 840", "zednik@center.cz");

            Vehicle vehicle1 = new Vehicle("Mercedes-Benz", "ML", "2AV 2930", "4JGDF7DE9DA203107");
            Vehicle vehicle2 = new Vehicle("Dodge", "Charger", "4PP 0232", "2B3KA43R68H249631");
            Vehicle vehicle3 = new Vehicle("Skoda", "Fabia", "1AP 5023", "6A3KB45R6GS249631");
            Vehicle vehicle4 = new Vehicle("Skoda", "Octavia", "8PO 9340", "7823KAS45R654249631");

            Repair repairPraha1 = new Repair(vehicle1, servicePraha.Employees[0], clientPraha1, 100302, "Výměna oleje", RandomizerHelper.GetRandomDate());
            Repair repairPraha2 = new Repair(vehicle3, servicePraha.Employees[1], clientPraha2, 345021, "STK", RandomizerHelper.GetRandomDate());
            Repair repairPraha3 = new Repair(vehicle2, servicePraha.Employees[2], clientPraha2, 90022, "STK + Emise", RandomizerHelper.GetRandomDate());
            servicePraha.AddRepair(repairPraha1);
            servicePraha.AddRepair(repairPraha2);
            servicePraha.AddRepair(repairPraha3);
            servicePraha.PrintRepairs();

            Repair repairPlzen1 = new Repair(vehicle3, servicePlzen.Employees[0], clientPlzen1, 10293, "Geometrie", RandomizerHelper.GetRandomDate());
            Repair repairPlzen2 = new Repair(vehicle3, servicePlzen.Employees[1], clientPlzen1, 30231, "STK", RandomizerHelper.GetRandomDate());
            servicePlzen.AddRepair(repairPlzen1);
            servicePlzen.AddRepair(repairPlzen2);

            Repair repairBrno1 = new Repair(vehicle4, serviceBrno.Employees[0], clientBrno1, 239412, "Výměna oleje", RandomizerHelper.GetRandomDate());
            serviceBrno.AddRepair(repairBrno1);

            Console.WriteLine("---===&&&===---");
            // QUERIES:
            // All employees from every service
            List<Employee> allEmployees = new List<Employee>();
            foreach (CarService service in carServices)
            {
                allEmployees.AddRange(service.Employees);
            }

            // Qualified employees from every service
            List<Employee> qualifiedEmployees = allEmployees.Where(i => i.Certified == true).ToList();
            Console.WriteLine("Vsechny zamestnanci ze vsech servisu s kvalifikacnim kurzem: ");
            foreach (Employee employee in qualifiedEmployees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();

            // All repairs from every service
            List<Repair> allRepairs = new List<Repair>();
            foreach (CarService service in carServices)
            {
                allRepairs.AddRange(service.Repairs);
            }

            // All repaired unique vechicles with greater than 100.000 km
            List<Vehicle> vehiclesQueried = allRepairs.Where(i => i.Milage > 100000).Select(i => i.Vehicle).Distinct().ToList();
            Console.WriteLine("Vsechny vozidla ze vsech autoservisu s najezdem vetsim nez 100000 km: ");
            foreach(Vehicle vehicle in vehiclesQueried)
            {
                Console.WriteLine(vehicle);
            }
            Console.WriteLine();

            // All repairs done by employee with index 0 in servicePraha
            List<Repair> repairsByEmployee = allRepairs.Where(i => i.Employee == employeePraha1).ToList();
            Console.WriteLine("Vsechny opravy technikem 'employeePraha1': ");
            foreach (Repair repair in repairsByEmployee)
            {
                Console.WriteLine(repair);
            }
            Console.WriteLine("---===&&&===---");
        }
    }
}
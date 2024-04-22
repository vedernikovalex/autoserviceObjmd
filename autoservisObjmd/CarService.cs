using System;
using System.Collections.Generic;

namespace autoservisObjmd
{
    /// <summary>
    /// Represents a car service center.
    /// </summary>
    public class CarService
    {
        private string name;
        private Owner owner;
        private string address;
        private List<Employee> employees = new List<Employee>();
        private List<Repair> repairs = new List<Repair>();

        /// <summary>
        /// Gets the list of employees in the car service.
        /// </summary>
        public List<Employee> Employees
        {
            get { return employees; }
        }

        /// <summary>
        /// Gets the list of repairs conducted in the car service.
        /// </summary>
        public List<Repair> Repairs
        {
            get { return repairs; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarService"/> class.
        /// </summary>
        /// <param name="name">The name of the car service.</param>
        /// <param name="owner">The owner of the car service.</param>
        /// <param name="address">The address of the car service.</param>
        public CarService(string name, Owner owner, string address)
        {
            this.name = name;
            this.owner = owner;
            this.address = address;
        }

        /// <summary>
        /// Adds an employee to the car service.
        /// </summary>
        /// <param name="employeeToAdd">The employee to add.</param>
        public void AddEmployee(Employee employeeToAdd)
        {
            employees.Add(employeeToAdd);
        }

        /// <summary>
        /// Prints all employees of the car service.
        /// </summary>
        public void PrintEmployees()
        {
            Console.WriteLine($"Výpis všech zaměstnanců z servisu {name}: ");
            OutputHelper.PrintListOfObjects(employees);
        }

        /// <summary>
        /// Adds a repair record to the car service.
        /// </summary>
        /// <param name="vehicle">The vehicle being repaired.</param>
        /// <param name="employee">The employee conducting the repair.</param>
        /// <param name="client">The client requesting the repair.</param>
        /// <param name="milage">The mileage of the vehicle.</param>
        /// <param name="description">A description of the repair.</param>
        public void AddRepair(Vehicle vehicle, Employee employee, Client client, int milage, string description)
        {
            Repair repairToAdd = new Repair(vehicle, employee, client, milage, description, DateTime.Now);
            repairs.Add(repairToAdd);
        }

        /// <summary>
        /// Prints all repair records of the car service.
        /// </summary>
        public void PrintRepairs()
        {
            Console.WriteLine($"Výpis všech záznamů oprav z servisu {name}: ");
            OutputHelper.PrintListOfObjects(repairs);
        }

        /// <summary>
        /// Returns a string representation of the car service.
        /// </summary>
        /// <returns>A string representation of the car service.</returns>
        public override string? ToString()
        {
            return $"Autoservis {name} vlasněn {owner.FirstName} {owner.LastName} se nachází na adrese {address}";
        }
    }
}

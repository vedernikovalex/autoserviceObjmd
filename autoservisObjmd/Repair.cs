using System;

namespace autoservisObjmd
{
    /// <summary>
    /// Represents a repair record containing information about a vehicle repair.
    /// </summary>
    public class Repair
    {
        private Vehicle vehicle;
        private Employee employee;
        private Client client;
        private int milage;
        private string description;
        private DateTime date;

        /// <summary>
        /// Gets the vehicle associated with the repair.
        /// </summary>
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        /// <summary>
        /// Gets the employee who performed the repair.
        /// </summary>
        public Employee Employee
        {
            get { return employee; }
        }

        /// <summary>
        /// Gets the milage of the vehicle at the time of the repair.
        /// </summary>
        public int Milage
        {
            get { return milage; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Repair"/> class with
        /// the specified parameters.
        /// </summary>
        /// <param name="vehicle">The vehicle being repaired.</param>
        /// <param name="employee">The employee performing the repair.</param>
        /// <param name="client">The client who owns the vehicle.</param>
        /// <param name="milage">The milage of the vehicle at the time of the repair. Cannot be negaitive.</param>
        /// <param name="description">The description of the repair work.</param>
        /// <param name="date">The date of the repair that cannot be in the future.</param>
        public Repair(Vehicle vehicle, Employee employee, Client client, int milage, string description, DateTime date)
        {
            if (milage < 0)
            {
                throw new ArgumentException("Mileage cannot be negative.", nameof(milage));
            }

            if (date > DateTime.Now)
            {
                throw new ArgumentException("Date cannot be in the future.", nameof(date));
            }

            this.vehicle = vehicle;
            this.employee = employee;
            this.client = client;
            this.milage = milage;
            this.description = description;
            this.date = date;
        }

        /// <summary>
        /// Returns a string that represents the current repair object.
        /// </summary>
        /// <returns>A string containing information about the repair.</returns>
        public override string? ToString()
        {
            return $"Záznam o opravě dne {date.Day}.{date.Month}.{date.Year} vozidla '{vehicle}' s najetými {milage} km. \n" +
                $" Práce provedena '{employee}' pro klienta '{client}' s popisem provedené práce: '{description}'";
        }
    }
}

using System;

namespace autoservisObjmd
{
    /// <summary>
    /// Represents a vehicle with manufacturer, model, plate number, and VIN number.
    /// </summary>
    public class Vehicle
    {
        private string manufacturer;
        private string model;
        private string plateNumber;
        private string vinNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class with the specified parameters.
        /// </summary>
        /// <param name="manufacturer">The manufacturer of the vehicle.</param>
        /// <param name="model">The model of the vehicle.</param>
        /// <param name="plateNumber">The plate number of the vehicle.</param>
        /// <param name="vinNumber">The VIN number of the vehicle.</param>
        public Vehicle(string manufacturer, string model, string plateNumber, string vinNumber)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.plateNumber = plateNumber;
            this.vinNumber = vinNumber;
        }

        /// <summary>
        /// Returns a string that represents the current vehicle object.
        /// </summary>
        /// <returns>A string containing the manufacturer, model, plate number, and VIN number of the vehicle.</returns>
        public override string? ToString()
        {
            return $"{manufacturer} {model} {plateNumber} {vinNumber}";
        }
    }
}

using System;

namespace autoservisObjmd
{
    /// <summary>
    /// Represents an owner derived from the <see cref="Person"/> class,
    /// with additional address information.
    /// </summary>
    public class Owner : Person
    {
        private string address;

        /// <summary>
        /// Initializes a new instance of the <see cref="Owner"/> class with
        /// the specified parameters.
        /// </summary>
        /// <param name="firstName">The first name of the owner.</param>
        /// <param name="lastName">The last name of the owner.</param>
        /// <param name="address">The address of the owner.</param>
        public Owner(string firstName, string lastName, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
        }

        /// <summary>
        /// Gets the first name of the owner.
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
        }

        /// <summary>
        /// Gets the last name of the owner.
        /// </summary>
        public string LastName
        {
            get { return lastName; }
        }

        /// <summary>
        /// Returns a string that represents the current owner object.
        /// </summary>
        /// <returns>A string containing the first name, last name, and address of the owner.</returns>
        public new string? ToString()
        {
            return $"{firstName} {lastName} {address}";
        }
    }
}

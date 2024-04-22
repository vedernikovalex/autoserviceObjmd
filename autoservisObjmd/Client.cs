using System;

namespace autoservisObjmd
{
    /// <summary>
    /// Represents a client derived from the <see cref="Person"/> class,
    /// with additional contact information as phone number and email.
    /// </summary>
    public class Client : Person
    {
        private string phoneNumber;
        private string email;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class with
        /// the specified parameters.
        /// </summary>
        /// <param name="firstName">The first name of the client.</param>
        /// <param name="lastName">The last name of the client.</param>
        /// <param name="phoneNumber">The phone number of the client.</param>
        /// <param name="email">The email address of the client.</param>
        public Client(string firstName, string lastName, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        /// <summary>
        /// Returns a string that represents the current client object.
        /// </summary>
        /// <returns>A string containing the first name, last name, phone
        /// number, and email of the client.</returns>
        public new string? ToString()
        {
            return $"{firstName} {lastName} {phoneNumber} {email}";
        }
    }
}

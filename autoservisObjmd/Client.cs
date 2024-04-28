using System;
using System.Text.RegularExpressions;

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
        /// <param name="phoneNumber">The phone number of the client with specific format rule.</param>
        /// <param name="email">The email address of the client with right format rule.</param>
        public Client(string firstName, string lastName, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            if (!IsValidPhoneNumber(phoneNumber))
            {
                throw new ArgumentException("Invalid phone number format.");
            }

            if (!IsValidEmail(email))
            {
                throw new ArgumentException("Invalid email format.");
            }

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

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^(?:\+420|420)?\s*([1-9][0-9]{2})\s*([0-9]{3})\s*([0-9]{3})$"; 
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private bool IsValidEmail(string email)
        {
            // Regex pattern for email validation
            string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}

using System;

namespace autoservisObjmd
{
    /// <summary>
    /// Represents an employee derived from the <see cref="Person"/> class,
    /// with additional address information as position and certified status.
    /// </summary>
    public class Employee : Person
    {
        private string position;
        private bool certified;

        /// <summary>
        /// Gets the position of the employee.
        /// </summary>
        public string Position
        {
            get { return this.position; }
        }

        /// <summary>
        /// Gets a value indicating whether the employee is certified.
        /// </summary>
        public bool Certified
        {
            get { return this.certified; }
        }

        /// <summary>
        /// Confirms the certification status of the employee.
        /// </summary>
        public void ConfirmCertificate()
        {
            this.certified = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class with
        /// the specified parameters.
        /// </summary>
        /// <param name="firstName">The first name of the employee.</param>
        /// <param name="lastName">The last name of the employee.</param>
        /// <param name="position">The position of the employee.</param>
        /// <param name="certified">The certification status of the employee.</param>
        public Employee(string firstName, string lastName, string position, bool certified)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
            this.certified = certified;
        }

        /// <summary>
        /// Returns a string that represents the current employee object.
        /// </summary>
        /// <returns>A string containing information about the employee.</returns>
        public override string? ToString()
        {
            return $"Zaměstnanec {this.firstName} {this.lastName} na pozici {this.position} {(certified ? "s certifikací" : "bez certifikace")}";
        }
    }
}

using System;

namespace autoservisObjmd
{
    /// <summary>
    /// Represents a person with a first name and a last name.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// The first name of the person.
        /// </summary>
        protected string? firstName = null;

        /// <summary>
        /// The last name of the person.
        /// </summary>
        protected string? lastName = null;

        /// <summary>
        /// Returns a string that represents the current person object.
        /// </summary>
        /// <returns>A string containing the first name followed by the
        /// last name.</returns>
        public override string? ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}

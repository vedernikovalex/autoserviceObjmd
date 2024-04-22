using System;
using System.Collections.Generic;
using System.Text;

namespace autoservisObjmd
{
    /// <summary>
    /// Provides helper methods for printing lists of objects.
    /// </summary>
    public class OutputHelper
    {
        /// <summary>
        /// Prints a list of objects to the console.
        /// </summary>
        /// <typeparam name="T">The type of objects in the list.</typeparam>
        /// <param name="listOfObjects">The list of objects to print.</param>
        public static void PrintListOfObjects<T>(List<T> listOfObjects)
        {
            StringBuilder sb = new StringBuilder();
            foreach (T objectToPrint in listOfObjects)
            {
                if (objectToPrint != null)
                {
                    sb.AppendLine(objectToPrint.ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

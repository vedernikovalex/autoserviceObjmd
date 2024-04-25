using System;

namespace autoservisObjmd
{
    /// <summary>
    /// Provides helper methods for generating random values.
    /// </summary>
    public class RandomizerHelper
    {
        private static Random gen = new Random();

        /// <summary>
        /// Generates a random date within a range from 1995-01-01 to today's date.
        /// </summary>
        /// <returns>A random DateTime value.</returns>
        public static DateTime GetRandomDate()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}

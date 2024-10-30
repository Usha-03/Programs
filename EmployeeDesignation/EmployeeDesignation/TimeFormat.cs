using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDesignation
{
public class UserProgramCode
    {
        public static int validateTime(string time)
        {
            // Split time into parts: "09:59 pm" -> ["09", "59", "pm"]
            string[] timeParts = time.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

            // Check if we have exactly 3 parts: hours, minutes, and AM/PM
            if (timeParts.Length != 3)
            {
                return -1;
            }

            // Define valid hours, minutes, and periods (AM/PM)
            List<string> validHours = new List<string> { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            List<string> validMinutes = new List<string>();
            for (int i = 0; i < 60; i++)
            {
                validMinutes.Add(i.ToString("D2"));  // "00", "01", ..., "59"
            }
            List<string> validPeriods = new List<string> { "am", "pm" };

            // Extract hours, minutes, and period from input
            string hours = timeParts[0];
            string minutes = timeParts[1];
            string period = timeParts[2].ToLower();  // Convert AM/PM to lowercase for easy comparison

            // Validate hours, minutes, and period
            if (validHours.Contains(hours) && validMinutes.Contains(minutes) && validPeriods.Contains(period))
            {
                return 1;  // Valid time
            }

            return -1;  // Invalid time
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Get input from the user
            Console.WriteLine("Enter the time in hh:mm am/pm format :");
            string inputTime = Console.ReadLine();

            // Call the validateTime method
            int result = UserProgramCode.validateTime(inputTime);

            // Print result based on the return value
            if (result == 1)
            {
                Console.WriteLine("Valid time format");
            }
            else
            {
                Console.WriteLine("Invalid time format");
            }
        }
    }

}

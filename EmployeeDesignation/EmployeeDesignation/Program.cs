
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDesignation
{
    internal class Coll5EmpDes2
    {
        static void Main()
        {
            
           int n = int.Parse(Console.ReadLine());
            string[] input1 = new string[n];

            for (int i = 0; i < n; i++)
            {
                input1[i] = Console.ReadLine();
            }

            string input2 = Console.ReadLine();
            string[] result = Coll5EmpDes2.GetEmployee(input1, input2);

            Console.WriteLine(string.Join(" ", result));
        }

        public static string[] GetEmployee(string[] input1, string input2)
        {
            if (input1.Any(emp => emp.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c))) ||
                !input2.All(char.IsLetter))
            {
                return new[] { "Invalid Input" };
            }

            List<string> employees = new List<string>();
            int totalEmployees = input1.Length / 2;

            for (int i = 1; i < input1.Length; i += 2)
            {
                if (i < input1.Length && input1[i].Equals(input2, StringComparison.OrdinalIgnoreCase))
                {
                    employees.Add(input1[i - 1]);
                }
            }

            if (!employees.Any())
            {
                return new[] { $"No employee for {input2} designation" };
            }
            if (employees.Count == totalEmployees)
            {
                return new[] { $"All employees belong to same {input2} designation" };
            }
            return employees.ToArray();
        }
    }
}

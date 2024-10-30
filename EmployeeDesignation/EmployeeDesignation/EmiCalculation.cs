using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDesignation
{
    internal class EmiCalculation
    {
        public static int checkEmpAgeEligible(string input1,int input2)
        {
            int studentEligibleLoanAmount = 200000;
            int employeeEligibleLoanAmount = 300000;
            int retiredEligibleLoanAmount = 500000;
            int studentRateOfInterest = 3;
            int employeeRateOfInterest = 5;
            int retiredRateOfInterest = 7;
            double age = checkDateFormat(input1);
            if (age == -1)
            {
                return -1;
            }
            if(!checkEmiMonths(input2))
            {
                return -2;
            }
            if(age<=22.2)
            {
                return getEmiPerMonth(studentEligibleLoanAmount, studentRateOfInterest, input2);
            }
            else if(age<=45 && age>22)
            {
                return getEmiPerMonth(employeeEligibleLoanAmount, employeeRateOfInterest, input2);
            }
            else
            {
                return getEmiPerMonth(retiredEligibleLoanAmount, retiredRateOfInterest, input2);
            }
        }
        static double checkDateFormat(string date)
        {
            DateTime birthDate;
            DateTime currentDate = DateTime.Now;
            bool isValidDate = DateTime.TryParseExact(date, "dd-mm-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate);
            if(!isValidDate)
            {
                return -1;
            }
            TimeSpan ageTimeSpan = currentDate - birthDate;
            double totalDays = ageTimeSpan.TotalDays;
            double age = totalDays / 365.25;
            return age;
        }
        static bool checkEmiMonths(int emiMonth)
        {
            List<int> emiMonths = new List<int> { 12, 24, 36, 48 };
            return emiMonths.Contains(emiMonth);
        }
        static int getEmiPerMonth(int eligibleLoanAmount,int rateOfInterest,int emiMonths)
        {
            int years = emiMonths / 12;
            int interestPerYear = eligibleLoanAmount * rateOfInterest / 100;
            int loanAmountWithInterest = eligibleLoanAmount + interestPerYear * years;
            return loanAmountWithInterest / emiMonths;
        }
    }
    public class Program1
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            string input1 = inputs[0];
            int input2 = int.Parse(inputs[1]);
            int emi = EmiCalculation.checkEmpAgeEligible(input1, input2);
            Console.WriteLine(emi);
        }
    }
}

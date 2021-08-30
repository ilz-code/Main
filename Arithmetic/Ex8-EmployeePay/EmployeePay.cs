using System;

namespace Ex8_EmployeePay
{
   public class EmployeePay
    {
        public static string ToPay(double hourPay, double workedHours)
        {
            if (hourPay < 8.0)
                return "Base pay must be at least 8 $ per hour!";

            if (workedHours > 60)
                return "Worked hours may not exceed 60!";
            else if (workedHours <= 40)
                return Convert.ToString(Math.Round(workedHours * hourPay, 2));
            else
                return Convert.ToString(Math.Round(40 * hourPay + (workedHours - 40) * hourPay * 1.5, 2));
        }
    }
}

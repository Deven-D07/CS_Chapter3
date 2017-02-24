using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string PayString;
            string HoursString;
            decimal PayRate;
            decimal HoursWorked;
            decimal GrossPay;
            decimal Tax;
            decimal Withhold;
            decimal NetPay;

         
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("  Please Enter An Hourly Pay Rate :  ");
            PayString = System.Console.ReadLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("  Please Enter Hours Worked :  ");
            HoursString = System.Console.ReadLine();

            
            PayRate = Convert.ToDecimal(PayString);
            HoursWorked = Convert.ToDecimal(HoursString);

            GrossPay = PayRate * HoursWorked;

            if (GrossPay <= 300)
                Tax = .1M;
            else
                Tax = .12M;

            Withhold = GrossPay * Tax;

            NetPay = GrossPay - Withhold;

         
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Gross Pay =  {0}", GrossPay);
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Withholding Tax = {0}", Withhold);
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Net Pay =  {0}", NetPay);

           
            System.Console.ReadLine();
        }
    }
}

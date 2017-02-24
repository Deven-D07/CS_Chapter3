using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your hourly pay rate? $");
            double payrate = Convert.ToDouble(Console.ReadLine());
            if (payrate < 5.65 || payrate > 49.99)
            {
                Console.Write("That didn't look right. Type it again: $");
                payrate = Convert.ToDouble(Console.ReadLine());
                if (payrate < 5.65 || payrate > 49.99)
                    Console.WriteLine("ERROR: Your hourly pay rate isn't valid.");
                else
                {
                    Console.WriteLine("\n- Pay rate: ${0}", payrate);
                    Console.WriteLine("- Weekly rate: ${0}", Convert.ToString(Convert.ToDouble(payrate) * 40));
                }
            }
            else
            {
                Console.WriteLine("\n- Pay rate: ${0}", payrate);
                Console.WriteLine("- Weekly rate: ${0}", Convert.ToString(Convert.ToDouble(payrate) * 40));
            }
        }
    }
}

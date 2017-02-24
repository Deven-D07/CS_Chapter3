using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your hourly pay rate? ");

            if (Convert.ToDouble(Console.ReadLine()) < 5.65 || Convert.ToDouble(Console.ReadLine()) > 49.99)
                Console.WriteLine("ERROR: You're either being paid too little or too much.");
        }
    }
}

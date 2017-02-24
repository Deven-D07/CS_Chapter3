using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your hourly pay rate? ");

            if (Convert.ToDouble(Console.ReadLine()) <= 5.65)
                Console.WriteLine("ERROR: I'm pretty sure that's well below minimum wage.");
        }
    }
}

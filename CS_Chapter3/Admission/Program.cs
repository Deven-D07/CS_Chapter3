using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {

            string gpaString;
            string TestScoreString;
            decimal GPA;
            decimal TestScore;


            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("  Please Enter Your GPA (Grade Point Average) :  ");
            gpaString = System.Console.ReadLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("  Please Enter Your Admission Test Score :  ");
            TestScoreString = System.Console.ReadLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            GPA = Convert.ToDecimal(gpaString);
            TestScore = Convert.ToDecimal(TestScoreString);

            if ((GPA >= 3 && TestScore >= 60) || (GPA < 3 && TestScore >= 80))
                System.Console.WriteLine("Accept!");
            else
                System.Console.WriteLine("Reject");


            System.Console.ReadLine();


            {
            }
        }
    }
}

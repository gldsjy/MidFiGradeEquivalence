using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidFiGradeEquivalence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mg;
            int fg;

            Console.Write("Enter midterm grade: ");
            mg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter final grade: ");
            fg = Convert.ToInt32(Console.ReadLine());

            if (mg == 50)
            {
                Console.WriteLine("midterm grade = " + mg + " - Failed");
            }
            else if (mg > 50 && mg <= 70)
            {
                Console.WriteLine("midterm grade = " + mg + " - Fair");
            }
            else if (mg <= 70 && mg < 79)
            {
                Console.WriteLine("midterm grade = " + mg + " - Good");
            }
            else if (mg <= 80 && mg < 89)
            {
                Console.WriteLine("midterm grade = " + mg + " - Good");
            }
            else if (mg > 80 && mg <= 90)
            {
                Console.WriteLine("midterm grade = " + mg + " - Very Good");
            }
            else if (mg > 90 && mg < 100)
            {
                Console.WriteLine("midterm grade = " + mg + " - Excellent");
            }
            else
            {
                Console.WriteLine("please enter a valid grade");
            }

            if (fg == 50)
            {
                Console.WriteLine("final grade = " + fg + " - Failed");
            }
            else if (fg > 50 && fg <= 70)
            {
                Console.WriteLine("final grade = " + fg + " - Fair");
            }
            else if (fg <= 70 && fg < 79)
            {
                Console.WriteLine("final grade = " + fg + " - Good");
            }
            else if (fg <= 80 && fg < 89)
            {
                Console.WriteLine("final grade = " + fg + " - Good");
            }
            else if (fg > 80 && fg <= 90)
            {
                Console.WriteLine("final grade = " + fg + " - Very Good");
            }
            else if (fg > 90 && fg < 100)
            {
                Console.WriteLine("final grade = " + fg + " - Excellent");
            }
            else
            {
                Console.WriteLine("please enter a valid grade");
            }
            Console.ReadKey();
        }
    }
}

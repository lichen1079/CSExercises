using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Enter your marks :");
            x = Convert.ToDouble(Console.ReadLine());
            if (x >= 80 && x <= 100)
                Console.WriteLine("You scored " + x + " marks which is A grade.");
            
                else if (x >= 60 && x <= 79)
                    Console.WriteLine("You scored " + x + " marks which is B grade.");
                else if (x >= 40 && x <= 59)
                    Console.WriteLine("You scored " + x + " marks which is C grade.");
                else if (x >= 0 && x <= 39)
                    Console.WriteLine("You scored " + x + " marks which is F grade.");
            
            else Console.WriteLine("**Error**");

        }
    }
}
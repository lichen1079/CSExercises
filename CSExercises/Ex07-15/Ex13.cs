using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter the distance :");
            string distance = Console.ReadLine();
            x = Convert.ToDouble(distance);
            y = 2.40 + 0.4 * x;
            y = y * 10;
            Math.Ceiling(y);
            Console.WriteLine("Total fare = ${0:##.00}", Math.Ceiling(y)/10);
        }
    }
}

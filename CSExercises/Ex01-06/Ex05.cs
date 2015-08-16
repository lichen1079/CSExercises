using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Enter a double : ");
            string value = Console.ReadLine();
            x = Convert.ToDouble(value);
            System.Math.Sqrt(x);
            Console.WriteLine("Square root = {0:##.000}",System.Math.Sqrt(x));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
                double x,y;
            Console.WriteLine("Input the value of x : ");
            string value = Console.ReadLine();
            x = Convert.ToDouble(value);
            y = 2 * x * x - 4 * x + 3;
            Console.WriteLine("y = "+y);

        }
    }
}

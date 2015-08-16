using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double x,y;
            Console.WriteLine("Enter your salary : ");
            string value = Console.ReadLine();
            x = Convert.ToDouble(value);
            y= x+0.1*x+0.03*x;
            Console.WriteLine("Total Income =$ {0:##.00}", y);
        }
    }
}

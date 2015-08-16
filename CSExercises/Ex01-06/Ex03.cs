using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Enter a double : ");
            string value = Console.ReadLine();
            x = Convert.ToInt32(value);
            Console.WriteLine("Square = {0:0.00}", x * x);
        }
    }
}

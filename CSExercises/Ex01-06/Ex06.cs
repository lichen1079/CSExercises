using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter an integer : ");
            string value = Console.ReadLine();
            x = Convert.ToInt32(value);
            Math.Sqrt(x);
            Console.WriteLine("Square root = {0:##.000}", Math.Sqrt(x));
        }
    }
}

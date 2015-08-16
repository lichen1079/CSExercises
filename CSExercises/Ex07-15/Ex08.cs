using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double x,y;
            Console.WriteLine("Enter a temperature : ");
            string value = Console.ReadLine();
            x = Convert.ToDouble(value);
            y=1.8*x+32;
            Console.WriteLine("Temperature in Fahrenheit is "+y+ " degree");
        }
    }
}

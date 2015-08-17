using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double x,y;
            Console.WriteLine("Enter the distance travelled :");
            x=Convert.ToDouble(Console.ReadLine());
            x = x * 10;
            Math.Ceiling(x);
            x = Math.Ceiling(x) / 10;
            if (x <= 0.5)
            { y = 2.4;   
                Console.WriteLine("Taxi fare is $2.40");}
            else if (x <= 9)
            {
                y = 2.4 + 0.4 * 8.5;
                Console.WriteLine("Taxi fare is ${0:0.00}" , y);
            }
            else
            {
                y = 2.4 + 0.4 * 8.5 + (x - 9) * 0.5;
                Console.WriteLine("Taxi fare is ${0:0.00}" , y);
            }
   
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int x, y, i;
            i = 2;
            Console.WriteLine("Enter an integer :");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Math.Sqrt(x));
            
                for (i = 2; i <= y; i++)
                
                    if (x % i == 0)
                    {  Console.WriteLine("Not Prime.");
                    return;
                    }
                Console.WriteLine("Prime.");
                




        }
    }
}

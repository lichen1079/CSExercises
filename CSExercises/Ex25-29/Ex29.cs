using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int x, f, a;
            Console.WriteLine("Enter an integer :");
            x = Convert.ToInt32(Console.ReadLine());
            f = 1; a = 0;
            for (f = 1; f <= x/2; f++)
            {
                if (x % f == 0)
                    a = a + f;
            }
            if (a == x)
                Console.WriteLine("The number is a Perfect Number.");
            else
                Console.WriteLine("The number is Not a Perfect Number.");


        }
    }
}

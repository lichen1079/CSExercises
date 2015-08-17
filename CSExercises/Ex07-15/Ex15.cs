using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int x, a1,a2,a3;
            Console.WriteLine("Enter a three-digit number : ");
            x = Convert.ToInt32(Console.ReadLine());
            a1 = x / 100;
            a2 = (x / 10) % 10;
            a3=x%10;
            if (x==Math.Pow(a1,3)+Math.Pow(a2,3)+Math.Pow(a3,3))
            {
                Console.WriteLine("The number is an Armstrong Number.");
            }
            else
            {
                Console.WriteLine("The number is not an Armstrong Number.");
            }

        }
    }
}
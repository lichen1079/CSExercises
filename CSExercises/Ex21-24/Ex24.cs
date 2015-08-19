using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            double N=Convert.ToDouble(Console.ReadLine());
            

            Random r = new Random();
            double G = Convert.ToDouble(r.NextDouble());
            double x = G * (N + 1) + 1;

            while (x*x<=N-0.00001||x*x>=N+0.00001)
            {
                x = (x + N / x) / 2;
            }
            Console.WriteLine("The square root of {0} is {1:0.00000}.",N,x);
           


        }
    }
}

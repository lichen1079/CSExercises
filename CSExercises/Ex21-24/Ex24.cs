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
            Console.WriteLine("Enter an integer :");
            int N=Convert.ToInt32(Console.ReadLine());
            

            Random r = new Random();
            double G = Convert.ToDouble(r.Next(1, N));

            while (G*G<=N-0.00001||G*G>=N+0.00001)
            {
                G = (G + N / G) / 2;
            }
            Console.WriteLine("The square root of {0} is {1:0.00000}.",N,G);
           


        }
    }
}

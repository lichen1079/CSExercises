using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            int x=0;double S=0;
            Console.WriteLine("Enter an integer: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x >= 1 && x <= 25)
            {
                S = SQT(x);
                Console.WriteLine("The square root is:{0:0.00} ", S);
            }
            else
            {
                Console.WriteLine("Error!Enter a integer between 1 and 25.");
            }

        }

        public static double SQT(int y)
        {
            double SQT=0;            
            SQT = Math.Sqrt(y);
            return SQT;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            int count1, count2, count3, count4, i, j, k, l;
            Console.WriteLine("Enter the amount: ");
            double x = Convert.ToDouble(Console.ReadLine());
            x = x * 100;

            while (x >= 100)
            {
                count1 = 0;
                x = x - 100;
                count1++;
                for (i = 0; i < count1; i++)
                {
                    Console.WriteLine("100c");
                }
            }

            while (x >= 50)
            {
                count2 = 0;
                x = x - 50;
                count2++;
                for (j = 0; j < count2; j++)
                {
                    Console.WriteLine("50c");
                }
            }


            while (x >= 20)
            {
                count3 = 0;
                x = x - 20;
                count3++;
                for (k = 0; k < count3; k++)
                {
                    Console.WriteLine("20c");
                }
            }
            while (x >= 5)
            {
                count4 = 0;
                x = x - 5;
                count4++;
                for (l = 0; l < count4; l++)
                {
                    Console.WriteLine("5c");
                }
            }
                        
   
           
        }
    }
}

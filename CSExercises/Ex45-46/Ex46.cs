using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] A = new int[50];            
            int i,j,k; 
            int[] count = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Random r = new Random();
            for (i = 0; i < 50; i++)
            {
                A[i] = r.Next(0, 10);  //(-5,6)
                switch (A[i])
                {
                    case 0:
                        count[0]++;
                        break;
                    case 1:
                        count[1]++;
                        break;
                    case 2:
                        count[2]++;
                        break;
                    case 3:
                        count[3]++;
                        break;
                    case 4:
                        count[4]++;
                        break;
                    case 5:
                        count[5]++;
                        break;
                    case 6:
                        count[6]++;
                        break;
                    case 7:
                        count[7]++;
                        break;
                    case 8:
                        count[8]++;
                        break;
                    case 9:
                        count[9]++;
                        break;
                }
            }
            Console.WriteLine("Number\tOccurence");
            for (j = 0; j < 10; j++)
            {
                Console.Write("  {0}\t   {1}\t  ", j, count[j]);
            
                for(k=0;k<count[j];k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

        }
    }
}

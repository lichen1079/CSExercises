using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int i, j, k, temp;
            int[] ary = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };

            //Simplified Selection Sort
            for (i = 0; i < ary.Length - 1; i++)
            {
                for (j = i + 1; j < ary.Length; j++)
                {
                    if (ary[j] > ary[i])
                    {
                        temp = ary[i];
                        ary[i] = ary[j];
                        ary[j] = temp;
                    }

                }
                for (k = 0; k < ary.Length; k++)
                    Console.Write("{0} ", ary[k]);

                Console.WriteLine();
            }
            
            /* Refined Selection Sort            
            for (i = 0; i < ary.Length - 1; i++)
            {
                int max = i;
                for (j = i + 1; j < ary.Length; j++)
                {

                    if (ary[j] > ary[max])
                    {
                        max = j;
                    }
                    
                }
                temp = ary[i];
                ary[i] = ary[max];
                ary[max] = temp;
                for (k = 0; k < ary.Length; k++)
                    Console.Write("{0} ", ary[k]);

                Console.WriteLine();
             */
            }
        }
    }


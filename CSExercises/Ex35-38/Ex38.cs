using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[5] { 63, 29, 75, 82, 55 };
            int i, j, k,temp;
            string temp2;
            
            temp = 0; temp2 = "";


            for (i = 0; i < marks.Length; i++)
            {
                for (j = i + 1; j < marks.Length; j++)
                //        if (marks[i] < marks[j])
                //        {
                //            temp = marks[i]; temp2 = name[i];
                //            marks[i] = marks[j]; name[i] = name[j];
                //            marks[j] = temp; name[j] = temp2;
                //        }
                //    for (k = 0; k < marks.Length - 4; k++)
                //        Console.WriteLine("{0}\t{1}", marks[i],name[i]);              
                //}
                {
                    k = 0;
                    k = Convert.ToInt32(name[i].CompareTo(name[j]));
                    if (k > 0)
                    {
                        temp2 = name[i]; temp = marks[i];
                        name[i] = name[j]; marks[i] = marks[j];
                        name[j] = temp2; marks[j] = temp;
                    }                    
                }
                Console.WriteLine("{0}\t{1}", name[i], marks[i]);
            }
        }
    }
}

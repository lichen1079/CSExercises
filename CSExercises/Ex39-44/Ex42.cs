using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[]args)
        {
            
            Console.WriteLine("Enter string S1:");
            string St1= Console.ReadLine();
            Console.WriteLine("Enter string S2:");
            string St2= Console.ReadLine();
            int count = FindWord(St1, St2);
            Console.WriteLine(count);
            
        }
            

        public static int FindWord(string s1, string s2)
        {
            int i=0,j=-1;
            for (i = 0; i <= s1.Length - s2.Length; i++)
                if (s2[0] == s1[i])
                {
                    if (s2 == s1.Substring(i, s2.Length))
                        return i;
                }
                else
                    j = -1;
            return j;
            
        }

        }
    }


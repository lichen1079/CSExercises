using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter string S1:");
            string St1= Console.ReadLine();
            Console.WriteLine("Enter string S2:");
            string St2= Console.ReadLine();
            Console.WriteLine(InString(St1, St2));

        }
        public static bool InString(string s1, string s2)
        {
            int i;
            bool bl= false;
            for (i = 0; i <= s1.Length - s2.Length; i++)
                if (s2[0] == s1[i])
                {
                    if(s2==s1.Substring(i,s2.Length))
                        return true;

                }

            if (bl == false)
                return false;
            else return true;
        }
    }
}

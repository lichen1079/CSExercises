using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string s = Console.ReadLine();
            Console.WriteLine("Enter character c1: ");
            char c1  =Convert.ToChar( Console.ReadLine());
            Console.WriteLine("Substitute with : ");
            char c2 = Convert.ToChar(Console.ReadLine());
            string c = Substitute(s, c1, c2);
            Console.WriteLine("New string is: {0}", c);
        }
        public static string Substitute(string s, char c1, char c2)
        {
            int i = 0; 
            for (i = 0; i < s.Length; i++)
            {
                
                if (s[i].Equals(c1))
                {
                    s = s.Substring(0, i) + Convert.ToString(c2) + s.Substring(i + 1, s.Length-1);  
                }
               
            }
            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine().ToLower();
            char[] c = new char[] { '.', ' ' };
            string trimword = word.Trim(c);

            int i = 0;
            int flag = 0;
            for (i = 0; i < trimword.Length; i++)
            {
                if (trimword.Substring(i, 1).Equals(trimword.Substring(word.Length - 1 - i, 1)))
                    flag = 1;
                else
                    flag = 0;
            }
            if (flag == 1)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");  
        }
    }
}

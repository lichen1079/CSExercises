using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            int i;
            int j;
            Console.WriteLine("Enter a word or a sentence :");
            string s = Console.ReadLine();
            string[] splits = s.Split(' ');
            string temp = "";//empty string
            for (i = 0; i <splits.Length; i++)
            {
                string titles = splits[i].Substring(0, 1);
                string secondpart = splits[i].Substring(1, splits[i].Length - 1);
                string capital = titles.ToUpper();
                temp = temp + capital + secondpart + " ";       
            }            
            Console.WriteLine(temp);

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {

            //section A--using array method
            /*Console.WriteLine("Please enter a phrase");            
            string phrase=Console.ReadLine().ToLower();
            int total=0;
            int i = 0;
            for(i=0;i<phrase.Length;i++)
            if (phrase[i] == 'a' ||phrase[i] == 'e' || phrase[i] == 'i' || phrase[i] == 'o' || phrase[i] == 'u' )     
            {
                total++;
            }        
            Console.WriteLine("Total number of vowels :"+ total);
        */


            // section B--using array method
            /* Console.WriteLine("Please enter a phrase");
             string phrase = Console.ReadLine().ToLower();
             int totalA = 0; int totalE = 0; int totalI = 0; int totalO = 0; int totalU = 0;
             int i = 0;
             for (i = 0; i < phrase.Length; i++)
                 if (phrase[i] == 'a' ) totalA++;                
                 else if(phrase[i] == 'e') totalE++;
                 else if(phrase[i] == 'i') totalI++;
                 else if(phrase[i] == 'o') totalO++;
                 else if(phrase[i] == 'u') totalU++;

             Console.WriteLine("Number of a :" + totalA+"\nNumber of e :" + totalE+"\nNumber of i :" + totalI+"\nNumber of o :" + totalO+"\nNumber of u :"+totalU);
             */

            //section A--using substring method
            /*Console.WriteLine("Please enter a phrase");
            string phrase = Console.ReadLine().ToLower();
            int i = 0, total = 0;
            for (i = 0; i < phrase.Length; i++)
                if (phrase.Substring(i, 1).Equals("a")) total++;
                else if (phrase.Substring(i, 1).Equals("e")) total++;
                else if (phrase.Substring(i, 1).Equals("i")) total++;
                else if (phrase.Substring(i, 1).Equals("o")) total++;
                else if (phrase.Substring(i, 1).Equals("u")) total++;
            Console.WriteLine("Total number of vowels :" + total);
             */

            //section B--using substring method
            Console.WriteLine("Please enter a phrase");
            string phrase = Console.ReadLine().ToLower();
            int i = 0, totalA = 0, totalE = 0, totalI = 0, totalO = 0, totalU = 0;
            for (i = 0; i < phrase.Length; i++)
                if (phrase.Substring(i, 1).Equals("a")) totalA++;
                else if (phrase.Substring(i, 1).Equals("e")) totalE++;
                else if (phrase.Substring(i, 1).Equals("i")) totalI++;
                else if (phrase.Substring(i, 1).Equals("o")) totalO++;
                else if (phrase.Substring(i, 1).Equals("u")) totalU++;
            Console.WriteLine("Number of a :" + totalA + "\nNumber of e :" + totalE + "\nNumber of i :" + totalI + "\nNumber of o :" + totalO + "\nNumber of u :" + totalU);
        }
    }
}

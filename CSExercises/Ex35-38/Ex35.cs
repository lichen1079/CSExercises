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

            Console.WriteLine("Please enter a phrase");
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

        }
    }
}

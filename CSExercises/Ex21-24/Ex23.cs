using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int guess = r.Next(1, 10);
            int i = 1; 

           
            Console.WriteLine("Guess the number :");
            int a = Convert.ToInt32(Console.ReadLine());
            
            while(a!=guess)
            {
                Console.WriteLine("Try again!");
                a = Convert.ToInt32(Console.ReadLine());
                i++;            
            }

            if (i < 3)
                Console.WriteLine("Congratulations!\nYou took " + i + " attempts.\nYou are a Wizard!");
            else if (i < 6)
                Console.WriteLine("Congratulations!\nYou took " + i + " attempts.\nYou are a good guess!");
            else
                Console.WriteLine("Congratulations!\nYou took " + i + " attempts.\nYou are lousy!");
        }
    }
}

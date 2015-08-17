using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your gender(M or F) :");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter your age :");
            x=Convert.ToInt32(Console.ReadLine());


            if (gender == "M")
                {if(x>40)
                
                Console.WriteLine("Good Morning Uncle " + name);
                    else 
                    Console.WriteLine("Good Morning Mr."+name);
                }
            else 
            {  if(x>40)
                {
                Console.WriteLine("Good Morning Aunty "+name);
                }
                else
                 {
                Console.WriteLine("Good Morning Ms." + name);
                 }
                
                
            
            }
        }
    }
}
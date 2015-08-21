using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        static void Main(string[] args)
       {
            double i,f;
            Console.WriteLine("Enter a number: ");
            i = Convert.ToDouble(Console.ReadLine());
            f=Factorial(i);
            Console.WriteLine("The factorial is :"+f);            
        }
        public static double Factorial(double n)
        {
            double Factorial = 1;
            
            int j;
            if(n==0)
            {
                Factorial=1;
            }
            
            else if (n < 0)
            {
                Console.WriteLine("Error! Factorial of a negative number does not exist!");
            }
            else
                for (j = 1; j <= n; j++)
                {
                    Factorial=Factorial* j;
                }

            return Factorial;
        }
    }
}
        
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int a, b,x,LCM;
            Console.WriteLine("Enter A :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B :");
            b = Convert.ToInt32(Console.ReadLine());
            int c=a;
            int d=b;

            
            while(a!=b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            x = a;
            Console.WriteLine("HCF:" + x);


            LCM =(c*d) / x;
            Console.WriteLine("LCM:" + LCM);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            double x, y,star;
            for(x=1;x<=20;x++)                                       //for (x = -5; x >= -5 && x <= 5; x++)
            {
                y = 2 * x * x - 4 * x + 3;
                for (star = 1; star <= y; star++)
                    Console.Write("*");
                Console.WriteLine("\n");
            }
            
                
                                                                    //y = 2 * x * x - 4 * x + 3;
                                                                    //Console.WriteLine("x={0:0.0}\ty={1:0.0}",x,y);
            
        }
    }
}

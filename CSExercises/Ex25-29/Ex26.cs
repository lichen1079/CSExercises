using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double n, x, y, z;
            x = 1; y = 1; z = 1;
            for(n=1;n<=10;n++)
            {
                x = 1 / n;
                y = Math.Sqrt(n);
                z = n * n;
                Console.WriteLine("{0:0.00}\t{1:0.0##}\t{2:0.0##}\t{3:0.0##}", n, x, y, z);
            }
        }
    }
}

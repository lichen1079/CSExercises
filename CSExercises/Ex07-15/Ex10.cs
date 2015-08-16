using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            double a,b,c,d,x,y;
            Console.WriteLine("Enter coordinates of two points(in the order of x1,y1,x2 and y2): ");
            string value1 = Console.ReadLine();
            a = Convert.ToDouble(value1);
            string value2 = Console.ReadLine();
            b = Convert.ToDouble(value2);
            string value3 = Console.ReadLine();
            c = Convert.ToDouble(value3);
            string value4 = Console.ReadLine();
            d = Convert.ToDouble(value4);
            x = (c - a) * (c - a) + (d - b) * (d - b);
            y=System.Math.Sqrt(x);
            Console.WriteLine("Distance ={0:##.00} ", y);
        }
    }
}

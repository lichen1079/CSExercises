using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int x,  i;
            i = 2;
            x = 5;
            int ind = 0;
            //y = Convert.ToInt32(Math.Sqrt(x));
            for (x = 5; x <= 1000 ; x++)
            {
                ind = 0;
                for (i = 2; i < x && ind==0; i++)
                {
                    if ((x % i) == 0)
                        ind = 1;
                       
                }
                if (ind ==0)
                Console.WriteLine("{0}", x);
            }
                   
        }
    }
}

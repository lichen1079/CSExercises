using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int n, x,i;
            Console.WriteLine("Emter a number :");
            n = Convert.ToInt32(Console.ReadLine());
            x = 1;
           for (i = 1;i<=n; i++)
            {
                x = x* i;
            }
            Console.WriteLine("The value is : "+x);

        }
    }
}

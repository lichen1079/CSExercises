using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            //int i,j,k,count1, count2, count3;
            Console.WriteLine("Enter the amount: ");
            double x = Convert.ToDouble(Console.ReadLine());
          
            double y =Convert.ToInt32(Math.Floor(x * 100)/100);
            Console.WriteLine("{0}", y);

              
        }
    }
}

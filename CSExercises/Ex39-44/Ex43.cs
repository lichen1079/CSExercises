using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[]args)
        {

            
            Console.WriteLine("Enter an integer: ");
            int i = Convert.ToInt32(Console.ReadLine());
            string h = Hex(i);
            Console.WriteLine(h);

        }
        public static string Hex(int i)
        {
            string Hex = i.ToString("X2");
            return Hex;
        }
    }
}

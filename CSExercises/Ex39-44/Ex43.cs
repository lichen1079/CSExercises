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
            int i;
            string h;
            
            Console.WriteLine("Enter an integer: ");
            i = Convert.ToInt32(Console.ReadLine());
            h = Hex(i);
            Console.WriteLine(h);

        }
        public static string Hex(int i)
        {
            int Hex=0;
            Hex = Convert.ToString(i,16); 
            return Hex;
        }
    }
}

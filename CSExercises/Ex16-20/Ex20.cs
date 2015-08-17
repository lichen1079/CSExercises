using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    
        public class Ex20
        {
            public static void Main(string[] args)
            {
                int x, y, z;
                Console.WriteLine("Enter quantity for TV:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter quantity for DVD:");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter quantity for MP3:");
                z = Convert.ToInt32(Console.ReadLine());

                double Px = 900 * x, Py = 500 * y, Pz = 700 * z;
                double Pt = Px + Py + Pz;

                if(Pt<5000)
                {
                    Pt = Px + Py + Pz;
                    Console.WriteLine("Total price for this order is ${0:0.00}",Pt);

                }
                else if (Pt > 5000 && Px < 10000)
                {
                    Pt = 0.9 * Px + 0.9 * Py + Pz;
                    Console.WriteLine("Total price for this order is ${0:0.00}", Pt);
                }
                
                else
                {
                    Pt = 0.85 * Px + 0.85 * Py + Pz;
                    Console.WriteLine("Total price for this order is ${0:0.00}", Pt);
                }
                

            }
        }
}
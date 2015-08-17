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

                double Px = 900 * x;
                {
                    if (Px >= 5000 && Px < 10000)
                        Px = Px * 0.9;

                    else if (Px >= 10000)
                        Px = Px * 0.85;
                }

                double Py = 500 * y;
                {
                    if (Py >= 5000 && Px < 10000)
                        Py = Py * 0.9;

                    else if (Py >= 10000)
                        Py = Py * 0.85;
                }

                double Pz = 700 * z;
                double Pt = Px + Py + Pz;
                Console.WriteLine("Total price for this order is $" + Pt);


            }
        }
}
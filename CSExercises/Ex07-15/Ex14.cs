using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c, x, y,Area;
            Console.WriteLine("Enter lengths of triangle's three sides : ");
            string value1 = Console.ReadLine();
            a = Convert.ToInt32(value1);
            string value2 = Console.ReadLine();
            b = Convert.ToInt32(value2);
            string value3 = Console.ReadLine();
            c = Convert.ToInt32(value3);
            if ((a + b) > c)
            {
                if ((b + c) > a)
                {
                    if ((a + c) > b) //If a+b>c and a+c>b and b+c>a then it is valid  
                    {
                        x = (a + b + c) / 2;
                        y = x * (x - a) * (x - b) * (x - c);
                        Area = Math.Sqrt(y);
                     
                        Console.WriteLine("The area of triangle = " + Area);
                    }
                    else
                    {
                        Console.WriteLine("Triangle is not valid");
                    }
                }
                else
                {
                    Console.WriteLine("Triangle is not valid");
                }
            }
            else
            {
                Console.WriteLine("Triangle is not valid");
            }


            
          
            }

        }
    }
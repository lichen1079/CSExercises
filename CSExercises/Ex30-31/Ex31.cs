using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
          int x, f, a;
         
          for ( x = 1;  x <= 1000;  x++)
          {
                       
              f = 1; a = 0;
              for (f = 1; f <= x / 2; f++)
              {
                  if (x % f == 0)
                      a = a + f;
              }
              if (a == x)
              {
                  Console.WriteLine("{0}", x);
              }
          }
 
                
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int i, x, n, sum, ave;
            x = 0;          
            int[] sales = new int[12];   //Array 

            for (i = 0; i < 12; i++)            
            {                             
                Console.WriteLine("Enter the sales of month {0}", i);
                x = Convert.ToInt32(Console.ReadLine());
                sales[i] = x;            //引用
            }


            int min = sales[0];          // new int min and max
            int max = sales[0];

            for (i = 0; i < 12; i++)
            {
                if (min > sales[i]) min = sales[i];
                if (max < sales[i]) max = sales[i];
            }
            sum = 0;
            for (n=0;n<12;n++)
            {
                sum = sum + sales[n];
            }
            ave = sum / sales.Length;
            Console.WriteLine("Maximum Sales:{0}\nMinimum Sales:{1}\nAverage Sales:{2}",max,min,ave);


               








    
        }

    }

}





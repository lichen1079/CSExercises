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
            int x=0;
            int y=0;
            int i,k,n;
            int j = 0;
            int l = 0;
            int sum=0;
            int ave=0;
            int min=0;
            int max=0;
            int[]sales=new int[12];           
            
            for (i = 0; i < 12; i++)
            {
                Console.WriteLine("Enter the sales of month {0}",i);
                sales[i]=Convert.ToInt32(Console.ReadLine());
            }
           
            
            x=j;
            for(k=j+1;k<sales.Length;k++)
             {
               if (sales[x] > sales[k])
                        {
                          x=k;
                        }
            }
            min=j;
            
            y = l;
            for(k=l+1;k<sales.Length;k++)
              {
                if(sales[y]<sales[k])
                        {
                          y = k;
                        }
             }
            max = y;
            
            for(n=0;n<12;n++)
            {
                sum = sum + sales[n];
            }
            ave = sum / sales.Length;
            Console.WriteLine("Maximum Sales:{0}\nMinimum Sales:{1}\nAverage Sales:{2}",max,min,ave);


               








    
        }

    }

}





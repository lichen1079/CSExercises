using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] marks = new int[,] { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 }, { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };
            string[] sdtname = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            int i = 0, j = 0;
            double psntotalmarks = 0, wholecausemks = 0;
            double[] avepersub = new double[4];
            double[] variance = new double[4];
            double[] btwaverage = new double[4];
            double[] squsum = new double[4];
            double[] stddev = new double[4];

            //total marks obtained each student
            /* for (i = 0; i < 12; i++)
                 {
                     psntotalmarks = 0;
                     Console.Write("\n{0}", i);

                     for (j = 0; j < 4; j++)
                     {
                         Console.Write("\t{0}", marks[i, j]);

                         psntotalmarks = psntotalmarks + marks[i, j];
                         Console.Write("\t{0}", psntotalmarks);
                     }
                 }*/

            //class average and standard deviation for each subject
            /*for (j = 0; j < 4; j++)
            {
                wholecausemks = 0;
                squsum[j]= 0;
                for (i = 0; i < 12; i++)
                {
                    wholecausemks = wholecausemks + marks[i, j];
                }
                avepersub[j] = wholecausemks / 12.0;
                Console.WriteLine("\taverage for each subject{0:0.000}", avepersub[j]);
            }

            double[] sumofsqu = new double[4];           
            for (j = 0; j < 4; j++)
            {

                sumofsqu[j] = 0;
                for (i = 0; i < 12; i++)
                    {                   
                    sumofsqu[j] = sumofsqu[j] + Math.Pow((marks[i, j] - avepersub[j]), 2.0);                       
                    }
                Console.WriteLine("sum:{0:0.000}", sumofsqu[j]);
                variance[j] = sumofsqu[j] / 12;
                Console.WriteLine("variance :{0:0.000}", variance[j]);
                stddev[j] = Math.Sqrt(variance[j]);
                Console.WriteLine("standard deviation :{0:0.000}", stddev[j]);
             }
             */

            int classsum = 0; int classave = 0;
            for (i = 0; i < 12; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    classsum = classsum + marks[i, j];
                    //Console.Write("\t{0}", marks[i, j]);
                 }

            }
            classave = classsum / marks.Length;
            Console.WriteLine("overage average for the whole class is: {0} ",classave);



        }
    }
}




    


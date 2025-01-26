using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArraysTextBookTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1b
            /*
            int count = 0;
            bool birdFound = false;
            while (birdFound != true)
            {

                if (bird == birdName[count])
                {
                    birdFound = true;
                    Console.WriteLine("Enter the number of birds observed: ");
                    int birdsObserved = int.Parse(Console.ReadLine());
                    birdCount[count] = birdCount[count] + birdsObserved;
                }

                count++;
            }

            */

            //2
            /*
            int total = 0;

            for (int i = 0; i < birthWeights.Length(); i++)
            {

                total = total + birthWeights[i];

            }

            float average = total/(birthWeights.Length);
            float underweightThreshold = average - 500;

            int count = 0;

            for (int i = 0; i < birthWeights.Length(); i++)
            {

                if (birthWeights[i] < underweightThreshold)
                {
                    count++;
                }

            }
            int[] underweightBabies = [count];

            int index = 0;
            int uTotal = 0;
            float uAverage = 0.0;
            for (int i = 0; i < birthWeights.Length(); i++)
            {

                if (birthWeights[i] < underweightThreshold)
                {
                    underweightBabies[index] = birthWeights[i];
                    uTotal = uTotal + underweightBabies[index];
                    index++;
                }

            }
            uAverage = uTotal / count;

            Console.WriteLine(average.ToString());
            Console.WriteLine(uAverage.ToString());
            Console.ReadLine();
            */

            //3
            /*
            int total = 0;
            int[,] classMark = new int[5,3];
            for (int i = 0; i<5; i++)
            {

                for(int j = 0; j<3; j++)
                {

                    Console.WriteLine("Enter the mark that student {0} got on test {1}: ", (i + 1), (j + 1));
                    classMark[i,j] = int.Parse(Console.ReadLine());
                    total = total + classMark[i,j];

                }

            }

            float avr1;
            float avr2;
            float avr3;
            float avr4;
            float avr5;
            float classavr;

            avr1 = (classMark[0, 0] + classMark[0, 1] + classMark[0, 2]) / 3;
            avr2 = (classMark[1, 0] + classMark[1, 1] + classMark[1, 2]) / 3;
            avr3 = (classMark[2, 0] + classMark[2, 1] + classMark[2, 2]) / 3;
            avr4 = (classMark[3, 0] + classMark[3, 1] + classMark[3, 2]) / 3;
            avr5 = (classMark[4, 0] + classMark[4, 1] + classMark[4, 2]) / 3;

            classavr = total / 15;
            */

            //4
            int[,] grid = new int[10, 10];
            Random rnd = new Random();
            int row = rnd.Next(0,9);
            int col = rnd.Next(0,9);
            grid[row, col] = 1;

        }
    }
}

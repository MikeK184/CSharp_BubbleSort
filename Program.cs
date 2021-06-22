using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            int[] arrayOfNumbers = new int[20];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                int rand_num = rd.Next(5, 200);
                arrayOfNumbers[i] = rand_num;
            }

            Console.WriteLine("The generated numbers are:");
            for (int i = 0; i < arrayOfNumbers.Length; ++i)
            {
                Console.Write(arrayOfNumbers[i] + " ");
            }
                
            int biggerValue;
            bool didSwap;
            int numberOfRuns= 0;
            do
            {
                didSwap = false;
                numberOfRuns++;
                for (int i = 0; i < arrayOfNumbers.Length -1; i++)
                {
                    if(arrayOfNumbers[i] > arrayOfNumbers[i+1])
                    {
                        biggerValue = arrayOfNumbers[i + 1];
                        arrayOfNumbers[i + 1] = arrayOfNumbers[i];
                        arrayOfNumbers[i] = biggerValue;
                        didSwap = true;                       
                    }
                }
            } while (didSwap);

            for (int i = 0; i < arrayOfNumbers.Length; ++i)
            {
                if (i == 0)
                {
                    Console.WriteLine("\nResult is:");
                }
                Console.Write(arrayOfNumbers[i] + " ");
            }
            Console.WriteLine("\n" + numberOfRuns);
        }
    }
}

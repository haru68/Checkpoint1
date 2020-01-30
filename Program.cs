using System;

namespace Sartori_Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NewArray = SetArray();

            int SumOfArray = SummedValueOfArray(NewArray);
            Console.WriteLine("Sum of the elements in the array: " + SumOfArray);

            double MeanOfArray = MeanValueOfArray(NewArray);
            Console.WriteLine("Mean of the array: " + MeanOfArray);

            Console.WriteLine();
            Console.WriteLine("Sorted Array:");
            int[] ArraySort = SortedArray(NewArray);
            DisplayArray(ArraySort);


        }

        public static int[] SetArray()
        {
            // Create a new array of big size to store the values.
            int[] LargeIntegersArray = new int[256];
            int ArrayCounter = 0;
            for (ArrayCounter = 0; ArrayCounter < 256; ArrayCounter++)
            {
                Console.WriteLine("Please, enter a new integer to add in the array. A negative integer ends the initialization of the array.");
                int ArrayNumber = Convert.ToInt32(Console.ReadLine());
                if (ArrayNumber >= 0)
                {
                    LargeIntegersArray[ArrayCounter] = ArrayNumber;
                }
                else
                {
                    break;
                }
            }

            // Create a second array of a size which corresponds to the size of the number of integers 
            // & use the values of the big arrays to record them in this array.
            int[] IntegersArray = new int[ArrayCounter];
            for (int i = 0; i < ArrayCounter; i++)
            {
                IntegersArray[i] = LargeIntegersArray[i];
            }
            return IntegersArray;
        }

        public static int SummedValueOfArray(int[] Array)
        {
            // Fait la somme des éléments présent dans le tableau en itérant sur chacun des éléments du tableau et en les additionnant.
            int IntegersArraySum = 0;
            foreach (int item in Array)
            {
                IntegersArraySum = IntegersArraySum + item;
            }

            return IntegersArraySum;
        }

        public static double MeanValueOfArray(int[] Array)
        {
            // Pour faire la moyenne des valeurs dans le tableau, utilise la somme des éléments du tableau divisé par la longueur du tableau.
            int IntegersSum = SummedValueOfArray(Array);
            int ArrayLength = Array.Length;

            double MeanOfArray = Convert.ToDouble(IntegersSum) / ArrayLength;

            return MeanOfArray;
        }

        public static int[] SortedArray(int[] ArrayToSort)
        {
            // Sort array in ascending order.
            int arraylength = ArrayToSort.Length;

            for (int i = 0; i < arraylength; i++)
            {
                for (int j = 0; j < arraylength -1; j++)
                {
                    if (ArrayToSort[i] < ArrayToSort[j])
                    {
                        int temp = ArrayToSort[j];
                        ArrayToSort[j] = ArrayToSort[i];
                        ArrayToSort[i] = temp;
                    }
                }
            }
            return ArrayToSort;
        }

        public static void DisplayArray(int[] CurrentArray)
        {
            foreach (int item in CurrentArray)
            {
                Console.WriteLine(item);
            }
        }
    }

}

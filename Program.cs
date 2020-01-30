using System;

namespace Sartori_Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = SetArray();

            int sumOfArray = SummedValueOfArray(newArray);
            Console.WriteLine("Sum of the elements in the array: " + sumOfArray);

            double meanOfArray = MeanValueOfArray(newArray);
            Console.WriteLine("Mean of the array: " + meanOfArray);

            Console.WriteLine();
            Console.WriteLine("Sorted Array:");
            int[] arraySort = SortedArray(newArray);
            DisplayArray(arraySort);


        }

        public static int[] SetArray()
        {
            int[] largeIntegersArray = new int[256];
            int arrayCounter = 0;
            for (arrayCounter = 0; arrayCounter < 256; arrayCounter++)
            {
                Console.WriteLine("Please, enter a new integer to add in the array. A negative integer ends the initialization of the array.");
                int arrayNumber = Convert.ToInt32(Console.ReadLine());
                if (arrayNumber >= 0)
                {
                    largeIntegersArray[arrayCounter] = arrayNumber;
                }
                else
                {
                    break;
                }
            }

            int[] integersArray = new int[arrayCounter];
            for (int i = 0; i < arrayCounter; i++)
            {
                integersArray[i] = largeIntegersArray[i];
            }
            return integersArray;
        }

        public static int SummedValueOfArray(int[] Array)
        {
            int integersArraySum = 0;
            foreach (int item in Array)
            {
                integersArraySum = integersArraySum + item;
            }

            return integersArraySum;
        }

        public static double MeanValueOfArray(int[] array)
        {
            int integersSum = SummedValueOfArray(array);
            int arrayLength = array.Length;

            double meanOfArray = Convert.ToDouble(integersSum) / arrayLength;

            return meanOfArray;
        }

        public static int[] SortedArray(int[] arrayToSort)
        {
            int arraylength = arrayToSort.Length;

            for (int i = 0; i < arraylength; i++)
            {
                for (int j = 0; j < arraylength -1; j++)
                {
                    if (arrayToSort[i] < arrayToSort[j])
                    {
                        int temp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[i];
                        arrayToSort[i] = temp;
                    }
                }
            }
            return arrayToSort;
        }

        public static void DisplayArray(int[] currentArray)
        {
            foreach (int item in currentArray)
            {
                Console.WriteLine(item);
            }
        }
    }

}

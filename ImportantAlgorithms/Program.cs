using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            string choice;

            int[] array = new int[10];
            BubbleSort bubbleSort;
            InsertionSort insertionSort;

            RandomiseArray(array, min, max);
            DisplayArray(array);

            bubbleSort = new BubbleSort(array);
            insertionSort = new InsertionSort(array);

            choice = Console.ReadLine()[0].ToString().ToLower();

            switch (choice)
            {
                case "1":
                    array = bubbleSort.Sort();
                    break;
                case "2":
                    array = insertionSort.Sort();
                    break;
                default:
                    break;
            }

            DisplayArray(array);
        }

        public static void RandomiseArray(int[] array, int min, int max)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max);
            }
        }

        public static void DisplayArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item.ToString() + ", ");
            }

            Console.WriteLine();
        }
    }
}

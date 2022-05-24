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
            int searchValue;

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
                    DisplayArray(array);
                    break;
                case "2":
                    array = insertionSort.Sort();
                    DisplayArray(array);
                    break;
                case "3":
                    searchValue = int.Parse(Console.ReadLine());
                    BinarySearch(bubbleSort, array, searchValue);
                    break;
                default:
                    break;
            }

        }

        public static void BinarySearch(BubbleSort sorter, int[] array, int searchValue)
        {
            BinarySearch binarySearch = new BinarySearch(array);
            int pos;

            array = sorter.Sort();
            pos = binarySearch.Search(searchValue);

            DisplayArray(array);
            Console.WriteLine(searchValue.ToString() + " At pos: " + pos.ToString());
        }

        public static void RandomiseArray(int[] array, int min, int max)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                for (int y = 0; y < array.Length; y++)
                {
                    int randomNum = random.Next(min, max);
                    if (array[y] != randomNum)
                    {
                        array[i] = randomNum;
                    }
                    else
                    {
                        array[i] = random.Next(min, max);
                    }
                }
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

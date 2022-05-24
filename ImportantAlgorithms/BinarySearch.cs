using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantAlgorithms
{
    class BinarySearch
    {

        private int[] _array;

        public BinarySearch(int[] inArray)
        {
            _array = inArray;
        }

        public int Search(int searchValue)
        {
            int minNum, maxNum;
            minNum = 0;
            maxNum = _array.Length - 1;
            int mid = 0;

            while (minNum <= maxNum)
            {
                mid = (minNum + maxNum) / 2;

                if (_array[mid] == searchValue)
                {
                    return mid;
                }
                else if (_array[mid] > searchValue)
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }

            return -1;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantAlgorithms
{
    class InsertionSort
    {
        private int[] _array;

        public InsertionSort(int[] inArray)
        {
            _array = inArray;
        }

        public int[] Sort()
        {
            for (int i = 0; i < _array.Length - 1; i++)
            {
                for (int y = i + 1; y > 0; y--)
                {
                    if (_array[y - 1] > _array [y])
                    {
                        int temp = _array[y - 1];
                        _array[y - 1] = _array[y];
                        _array[y] = temp;
                    }
                }
            }

            return _array;
        }
    }
}

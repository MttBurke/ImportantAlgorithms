using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantAlgorithms
{
    class BubbleSort
    {

        private int[] _array;

        public BubbleSort(int[] inArray)
        {
            _array = inArray;
        }

        public int[] Sort()
        {
            int temp;

            for (int i = 0; i <= _array.Length - 2; i++)
            {
                for (int y = 0; y <= _array.Length - 2; y++)
                {
                    if (_array[y] > _array[y + 1])
                    {
                        temp = _array[y + 1];
                        _array[y + 1] = _array[y];
                        _array[y] = temp;
                    }
                }
            }

            return _array;
        }
    }
}

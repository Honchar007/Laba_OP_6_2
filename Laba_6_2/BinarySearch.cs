using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_2
{
    class BinarySearch<T>
    {
        //sdkfgjidfgdf]og
        //sdfgdfgdfgdfg
        public BinarySearch(int size)
        {
            myGenericArray = new T[size];
        }
        public T[] myGenericArray;
        static int Search(int left, int right, T[] array, T target)
        {
            if (right - left < 0) throw new Exception($"{target} не найден");
            var index = (right - left) / 2 + left;
            var item = array[index];
            var c = item.ToString();
            var compareResult = c.CompareTo(target.ToString());

            if (compareResult < 0)
                return Search(index + 1, right, array, target);
            if (compareResult > 0)
                return Search(left, index - 1, array, target);
            return index;
        }
    }
}

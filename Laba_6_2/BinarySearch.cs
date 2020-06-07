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
        public BinarySearch(int size, params T[] par )
        {
            myGenericArray = new T[size];
            par.CopyTo(myGenericArray,0);
        }
        public T[] myGenericArray { get; set; }
        public  int Search(int left, int right, T[] array, T target)
        {
            if (right - left < 0) throw new Exception($"{target} не найден");
            var index = (right - left) / 2 + left;
            //Console.WriteLine((right - left) / 2 + left);
            var item = array[index];
            var c =Convert.ToInt32( item);
            //Console.WriteLine(c+" "+ target.ToString());
            var compareResult = c.CompareTo(Convert.ToInt32(target));
           // Console.WriteLine(compareResult);
            if (compareResult < 0)
                return Search(index + 1, right, array, target);
            if (compareResult > 0)
                return Search(left, index - 1, array, target);
            return index;
        }
    }
}

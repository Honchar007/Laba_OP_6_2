using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch<string> binarySearch = new BinarySearch<string>(7,"a","b","bb","g","d","n","aa");
            BinarySearch<int> binarySearch2 = new BinarySearch<int>(8,2,15,32,56,78,90,123,162);
           
                Console.WriteLine("HONCHAR ANDII IP-91 var7 BINARY SEARCH");
            int x = 0;string y;
            while (true)
            {
                Console.WriteLine("Хотите искать, если нет, то введите нет?");
                y = Console.ReadLine();
                if (y.ToLower() == "нет") break;
                Console.WriteLine("Что ищем?");
              x=  int.Parse(Console.ReadLine());
                Console.Write("Индекс вашего числа: ");
                Console.WriteLine(binarySearch2.Search(0, 7, binarySearch2.myGenericArray, x)+1);
                //Console.WriteLine(binarySearch.Search(0, 6, binarySearch.myGenericArray, "b"));
               
            }

            Console.ReadLine();
        }
    }
}

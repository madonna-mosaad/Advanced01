using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced01
{
    class Bubble<T> where T : IComparable
    {
        public static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        public static void BubbleSort(T[] arr)
        {
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) == 1)
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }
    }
}

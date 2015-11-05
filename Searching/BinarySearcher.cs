using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class BinarySearver
    {
        static int Search_Iter<T>(T[] array, bool descendingOrder,T key,Comparison<T> compare)
        {
            int left = 0;
            int right = array.Length;
            int mid = 0;

            while (!(left >= right))
            {
                mid = left + (right - left) / 2;

                if (compare(array[left],key)==0)
                    return left;

                if (compare(array[mid], key) ==0)
                {
                    if (mid == left + 1)
                        return mid;
                    else
                        right = mid + 1;
                }

                else if ((compare(array[mid], key)==1) ^ descendingOrder)
                    right = mid;
                else
                    left = mid + 1;
            }

            return -1;
        }
        public static int Search<T>(T[] array,T key,Comparison<T> del)
        {
           
            bool descendingOrder;
            if (array.Length == 0)
                return -1;
          if(del==null)
            {
                throw new ArgumentNullException();
            }
          if(key==null)
            {
                throw new ArgumentNullException();
            }

            descendingOrder = del(array[0], array[array.Length - 1])==1;
            return Search_Iter(array, descendingOrder, key,del);
        }
    }
}

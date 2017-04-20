using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
   public static class IEnumerableЕxtensions
    {
        public static T SumOfCollection<T> (this IEnumerable<T> collection) where T: struct
        {
            T sum = (dynamic) 0;
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T ProductOfCollestion<T>(this IEnumerable<T> collection) where T : struct
        {
            T product = (dynamic)1;
            foreach (var item in collection)

            {
                product *= (dynamic)item;
            }
            return product;
        }
        public static T AverageOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            T average = (dynamic)0;
             average=(dynamic)SumOfCollection(collection)/collection.Count();


            return  average;
        }

        public static T MinOfCollection<T>(this IEnumerable<T> collection) where T:struct
        {
            var min = (dynamic)collection.First();
            foreach (var item in collection)
            {
                if (min>item)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T MaxOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            var max = (dynamic)collection.First();
            foreach (var item in collection)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            return max;
        }

    }
}

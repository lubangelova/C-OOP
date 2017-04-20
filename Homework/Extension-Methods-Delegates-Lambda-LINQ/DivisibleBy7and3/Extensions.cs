using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7and3.Extensions
{
     public static class Extensions
    {
        public static  IEnumerable<T> DivisibleBy7and3<T> (this IEnumerable<T> list) where T : struct
        {
            var result = list
                .Where(el => (dynamic)el % 7 == 0 && (dynamic)el % 3 == 0)
                .ToList();
            //foreach (var item in list)
            //{
            //    if((dynamic)item%7==0 && (dynamic)item%3==0)
            //    {
            //        result.Add(item);
            //    }
            //}
            return result;
        }
    }
}

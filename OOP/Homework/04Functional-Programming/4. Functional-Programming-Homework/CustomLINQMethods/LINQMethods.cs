using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQMethods
{
    public static class LINQMethods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            foreach (var item in collection)
            {
                if (!predicate(item))
                {
                   yield return item;
                }
            }
        } 

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            for (int i = 0; i < count; i++)
            {
                foreach (var item in collection)
                {
                    yield return item;  
                }                
            }            
        }

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            foreach (var item in collection)
            {
                if (item.EndsWith(suffixes.ToString()))
                {
                    yield return item;
                }
            }    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StringBuilder_Extensions
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder str, int startIndex, int length)
        {
            string result = str.ToString();
            result = result.Substring(startIndex, length);
            StringBuilder builderRes = new StringBuilder();
            builderRes.Append(result);
            return builderRes;
        }

        public static StringBuilder RemoveText(this StringBuilder str, string text)
        {
            int index = str.ToString().IndexOf(text);
            while (index > -1)
            {
                str.Remove(index, text.Length);
                index = str.ToString().IndexOf(text);
            }
            
            return str;
        }
        public static StringBuilder AppendAll<T>(this StringBuilder str, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                str.Append(item);
            }
            return str;
        }

        
    }
}

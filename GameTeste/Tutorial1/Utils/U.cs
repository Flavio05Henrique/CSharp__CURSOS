using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.Utils
{
    public static class U
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action )
        {
            foreach(var item in collection)
            {
                action(item);
            }
        }
    }
}

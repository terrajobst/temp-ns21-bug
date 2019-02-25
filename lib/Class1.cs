using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lib
{
    public class Class1
    {
        public static async IAsyncEnumerable<int> Run(int max)
        {
            while (max > 0)
            {
                await Task.Delay(100);

                yield return max;

                max--;
            }
        }
    }
}

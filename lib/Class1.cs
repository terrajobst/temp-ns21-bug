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

    public class Customer
    {
        public Customer()
        {
            FullName = "Immo Landwerth";
            FirstName = FullName[0..5];
            LastName = FullName[5..14];
        }

        public string FullName { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public int Count => 3;

        public string this[Index index]
        {
            get
            {
                return index.GetOffset(Count) switch
                {
                    0 => FullName,
                    1 => FirstName,
                    2 => LastName
                };
            }
        }
    }
}

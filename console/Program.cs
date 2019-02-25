using System;
using System.Threading.Tasks;
using lib;

namespace console
{
    class Program
    {
        async static Task Main(string[] args)
        {
            await foreach (var x in Class1.Run(10))
            {
                Console.WriteLine(x);
            }
        }
    }
}

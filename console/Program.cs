using System;
using System.Threading.Tasks;
using lib;

namespace console
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var c = new Customer();
            Console.WriteLine(c.FullName);
            Console.WriteLine(c.FirstName);
            Console.WriteLine(c.LastName);

            Console.WriteLine(c[0]);
            Console.WriteLine(c[1]);
            Console.WriteLine(c[2]);

            Console.WriteLine(c[^1]);
            Console.WriteLine(c[^2]);
            Console.WriteLine(c[^3]);

            await foreach (var x in Class1.Run(10))
            {
                Console.WriteLine(x);
            }
        }
    }
}

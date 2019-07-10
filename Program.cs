using System;

namespace euler_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var arg in args)
            {
                Console.WriteLine($"############### Beginning to solve problem {arg} ###############");

                // Do work here depending on problem

                Console.WriteLine($"############### Finished ###############");
            }            
        }
    }
}

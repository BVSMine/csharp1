using System;

namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bus b1 = new bus();
            b1.addPass("pnpdu");
            ticket t1 = new ticket();
            foreach (string i in b1.passengers) {
                Console.WriteLine(i);
                Console.WriteLine(b1.passengers.Count + t1.count);
            }
            t1.check();
        }
    }
}

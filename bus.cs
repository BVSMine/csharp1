using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp1
{
    class bus
    {
        public List<String> passengers = new List<string>();
        public void addPass(string name)
        {
            passengers.Add(name);
            Console.WriteLine("passenger entered into the bus");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp1
{
    class ticket:bus
    {
        public int coun=0;
        public void takeTicket()
        {
            coun = coun + 1;
        }
        public void check()
        {
            if ((passengers.Count)==coun)
            {
                Console.WriteLine("All has taken tickets"+passengers.Count+"citizen count"+coun);
            }
            else
            {
                Console.WriteLine(passengers.Count - coun + " has not taken ticket");
            }
        }
    }
}

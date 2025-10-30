using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Setting the string counter to 1
            int Counter = 1;
            int addBy = 1;

            //While loop part
            while (Counter <= 5)
            {   Console.WriteLine("While Loop Counter: " + Counter);
                Counter += addBy;
            }
        }
    }
}
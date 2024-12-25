using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6_delegates_events
{
    public class DelegateBasic
    {
        public delegate void MyDelegate(string message);

        public static void SayHello(string message)
        {
            Console.WriteLine($"Hello, {message}!");
        }

    }
}

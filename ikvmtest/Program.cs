using System;
using ikvmtest;
using sample;

namespace ikvmtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloworldImpl helloworld = new HelloworldImpl();
            Console.Write( helloworld.sayHello("sdafa"));
        }
    }
}

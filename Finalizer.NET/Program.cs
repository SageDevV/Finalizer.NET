using System;

namespace Finalizer.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (!Console.KeyAvailable)
            {
                MyObject obj = new(count++);
            }
        }
    }
}

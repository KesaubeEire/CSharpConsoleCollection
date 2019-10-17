using System;
using HF001__.Properties;

namespace HF001__
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            // Squeak
            Console.WriteLine("Squeak!!!");
        }
    }
}
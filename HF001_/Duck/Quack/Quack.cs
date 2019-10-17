using System;
using HF001__.Properties;

namespace HF001__
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            // Quack
            Console.WriteLine("Quack!!!");
        }
    }
}
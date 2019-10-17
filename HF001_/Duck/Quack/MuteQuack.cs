using System;
using HF001__.Properties;

namespace HF001__
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            // MuteQuack
            Console.WriteLine("MuteQuack!!!");
        }
    }
}
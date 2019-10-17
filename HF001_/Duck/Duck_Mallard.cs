using System;

namespace HF001__
{
    public class Duck_Mallard : Duck
    {
        public Duck_Mallard()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public void display()
        {
            Console.WriteLine("I'm a Mallard Duck!");
        }
    }
}
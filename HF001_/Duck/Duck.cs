using System;
using HF001__.Properties;

namespace HF001__
{
    public abstract class Duck
    {
        private IQuackBehavior _quackBehavior;
        private IFlyBehavior _flyBehavior;


        public IQuackBehavior QuackBehavior
        {
            get => _quackBehavior;
            set => _quackBehavior = value;
        }
        public IFlyBehavior FlyBehavior
        {
            get => _flyBehavior;
            set => _flyBehavior = value;
        }

        public Duck()
        {
        }


        public void Fly_perform()
        {
            FlyBehavior.fly();
        }

        public void Quack_perform()
        {
            QuackBehavior.quack();
        }


        public void Swim()
        {
            Console.WriteLine("Every Duck Even Decoy Swim!");
        }

        public void display()
        {
        }
    }
}
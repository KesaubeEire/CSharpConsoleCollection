using System;

namespace HF001__
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            // Normal Duck fly
            Console.WriteLine("FlyWithWings Duck fly");
        }
    }
}
using System;
using System.Management.Instrumentation;

namespace HF001__
{
    internal class Program
    {
        /// <summary>
        /// 第一个模式:**策略模式**的演示
        /// </summary>
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("========START========");

//            Duck_Mallard mallard = new Duck_Mallard();
//            mallard.Quack_perform();
//            mallard.Fly_perform();
//            mallard.display();
//            mallard.Swim();

            Duck model = new Duck_Model();
            model.FlyBehavior = new FlyRocketPowered();
            model.Fly_perform();
        }
    }
}
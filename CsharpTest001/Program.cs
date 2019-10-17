using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace CsharpTest001
{
    internal class Program
    {
        public static string _me = "I am the biggest Monster in the World!";

        static void Main(string[] args)
        {
            var a = new Program();
            a.PrinData();


            SubProgram subProgram = new SubProgram();
            subProgram.Star = "333";
            SubProgram subProgram2 = new SubProgram();
        }

        void KinectLink()
        {
        }

        public void PrinData()
        {
            DateTime _dateTime = DateTime.Now;
            Console.WriteLine($"Now is {_dateTime}!");
        }

        public static void PrintDataNext()
        {
            DateTime _dateTime = DateTime.Today;
            Console.WriteLine($"Now is {_dateTime}!");
        }

        class SubProgram
        {
            public static string StaStar = "23233";
            public string Star = "SkrSkr";
            Program _program = new Program();
            public const string a = "232";

            static void LikeProgram()
            {
                const string ab = "232";
            }

            void asIfWeAreFamiliy()
            {
                LikeProgram();
            }
        }
    }
}
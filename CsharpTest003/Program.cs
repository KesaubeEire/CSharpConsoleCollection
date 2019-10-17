namespace CsharpTest003
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ExternlClass _class = new ExternlClass(2, 3);
            ExternlClass _class2 = new ExternlClass {X1 = 3, Z1 = 3};
        }
    }

    partial class ExternlClass
    {
        public int X;
        public int Y;
        public int Z;

        public ExternlClass(int x, int y)
        {
            X = x;
            Y = y;
        }


        void Constract()
        {
            if (X > Y)
                X = 100;
            else
                Y = 40;
        }
    }

    partial class ExternlClass
    {
        public int X1;
        public int Y1;
        public int Z1;


        public ExternlClass()
        {
        }
    }
}
namespace HF001__
{
    public class Duck_Model : Duck
    {
        public Duck_Model()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }
    }
}
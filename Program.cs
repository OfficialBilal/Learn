using System;

namespace Learning
{
    public abstract class Customer
    {
        public abstract void Print();
    }
    public class Learn : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method");
        }
        public static void Main()
        {
            Learn P = new Learn();
            P.Print();
        }
    }
  
}

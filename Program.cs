namespace Learning
{     //Explicit Interface Implimentation
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }
    public class Program : I1, I2
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }
        static void Main(string[] args)
        {
           
        }
    }
}

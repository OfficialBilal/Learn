using System;

namespace Learn
{
    public class AccessSpecifiers
    {
        private void test1()
        {
            Console.WriteLine("This is Private");
        }
        internal void test2()
        {
            Console.WriteLine("This is Internal");
        }
        protected void test3()
        {
            Console.WriteLine("This is Protected");
        }
        protected internal void test4()
        {
            Console.WriteLine("This is Protected Internal");
        }
        public void test5()
        {
            Console.WriteLine("This is Public");
        }

        public static void Main()
        {
            AccessSpecifiers l = new AccessSpecifiers();
            l.test1();
            l.test2();
            l.test3();
            l.test4();
            l.test5();
            Console.ReadLine();
        }
    }
}


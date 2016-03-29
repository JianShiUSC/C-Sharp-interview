using System;
using System.Collections.Generic;
using System.Text;

namespace Example14
{
    class BaseClass
    {
        public virtual void F()
        {
            Console.WriteLine("BaseClass.F");
        }
    }
    abstract class DeriveClass1 : BaseClass
    {
        //在这里， abstract是可以和override一起使用的
        public abstract override void F();
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

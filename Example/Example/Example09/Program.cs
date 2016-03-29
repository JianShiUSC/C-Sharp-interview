using System;
using System.Collections.Generic;
using System.Text;

namespace Example09
{
    class BaseClass
    {
        public static double PI = 3.1415;
    }
    class DervieClass : BaseClass
    {
        //继承类发现该变量的值不能满足运算精度，于是可以通过new修饰符显式隐藏基类中的声明
        public new static double PI = 3.1415926;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BaseClass.PI);
            Console.WriteLine(DervieClass.PI);
            Console.ReadLine();
        }
    }
}

//3.1415
//3.1415926

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class App
    {
        //第一个参数必须是整型，但后面的参数个数是可变的。
        //而且由于定的是object数组，所有的数据类型都可以做为参数传入
        public static void UseParams(int id, params object[] list)
        {
            Console.WriteLine(id);
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static void Main()
        {
            //可变参数部分传入了三个参数，都是字符串类型
            UseParams(1, "a", "b", "c");
            //可变参数部分传入了四个参数，分别为字符串、整数、浮点数和双精度浮点数数组
            UseParams(2, "d", 100, 33.33, new double[] { 1.1, 2.2 });
            Console.ReadLine();
        }
    }
}



// 1
// a
// b
// c
// 2
// d
// 100
// 33.33
// System.Double[]

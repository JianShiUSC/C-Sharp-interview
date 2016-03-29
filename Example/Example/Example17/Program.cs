using System;
using System.Collections.Generic;
using System.Text;

namespace Example17
{
    class Program
    {
        //一个完整的接口声明示例
        interface IExample
        {
            //属性
            string P
            {
                get;
                set;
            }

            //方法
            string F(int Value);

            //事件
            event EventHandler E;

            //索引指示器
            string this[int Index]
            {
                get;
                set;
            }
        }

        interface IA
        {
            int Count { get; set;}
        }

        interface IB
        {
            int Count();
        }

        //IC接口从IA和IB多重继承
        interface IC : IA, IB
        {

        }

        class C : IC
        {
            private int count = 100;

            //显式声明实现IA接口中的Count属性
            int IA.Count
            {
                get { return 100; }
                set { count = value; }
            }

            //显式声明实现IB接口中的Count方法
            int IB.Count()
            {
                return count * count;
            }
        }

        static void Main(string[] args)
        {
            C tmpObj = new C();

            //调用时也要显式转换
            Console.WriteLine("Count property: {0}", ((IA)tmpObj).Count);
            Console.WriteLine("Count function: {0}", ((IB)tmpObj).Count());
            Console.ReadLine();
        }
    }
}


// Count property: 100
// Count function: 10000

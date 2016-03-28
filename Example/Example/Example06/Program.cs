using System;
using System.Collections.Generic;
using System.Text;

namespace Example06
{
    class Program
    {
        class A
        {
            public virtual void F()
            {
                Console.WriteLine("A.F");
            }
            public virtual void G()
            {
                Console.WriteLine("A.G");
            }
        }
        class B : A
        {
            public sealed override void F()
            {
                Console.WriteLine("B.F");
            }
            public override void G()
            {
                Console.WriteLine("B.G");
            }
        }
        class C : B
        {
            public override void G()
            {
                Console.WriteLine("C.G");
            }
        }
        static void Main(string[] args)
        {
            new A().F();
            new A().G();
            new B().F();
            new B().G();
            new C().F();
            new C().G();
            Console.ReadLine();
        }
    }
}




//类 B 在继承类 A 时可以重写两个虚函数：
//由于类 B 中对 F 方法进行了密封， 类 C 在继承类 B 时只能重写一个函数：
//控制台输出结果，类 C 的方法 F 只能是输出 类 B 中对该方法的实现：

//A.F
//A.G
//B.F
//B.G
//B.F
//C.G

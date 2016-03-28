using System;
using System.Collections.Generic;
using System.Text;
using Example02Lib;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            //修改 Example02 中 Class1 的 strConst 初始值后，只编译 Example02Lib 项目
            //然后到资源管理器里把新编译的Example02Lib.dll拷贝Example02.exe所在的目录，执行Example02.exe
            //切不可在IDE里直接调试运行因为这会重新编译整个解决方案！！
            //可以看到strConst的输出没有改变，而strStaticReadonly的输出已经改变
            //表明Const变量是在编译期初始化并嵌入到客户端程序，而StaticReadonly是在运行时初始化的
            Console.WriteLine("strConst : {0}", Class1.strConst);
            Console.WriteLine("strStaticReadonly : {0}", Class1.strStaticReadonly);
            Console.ReadLine();
        }
    }
}
//strConst : Const
//strStaticReadonly : StaticReadonly

//strConst : Const
//strStaticReadonly : StaticReadonly Changed

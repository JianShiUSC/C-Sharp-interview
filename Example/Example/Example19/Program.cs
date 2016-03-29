Class1.cs:
using System;
using System.Collections.Generic;
using System.Text;
namespace com.nblogs.reonlyrun.CSharp25QExample.Example19.Lib01
{
    class Class1
    {
        public override string ToString()
        {
            return "com.nblogs.reonlyrun.CSharp25QExample.Example19.Lib01's Class1";
        }
    }
}

Class2.cs：
using System;
using System.Collections.Generic;
using System.Text;
namespace com.nblogs.reonlyrun.CSharp25QExample.Example19.Lib02
{
    class Class1
    {
        public override string ToString()
        {
            return "com.nblogs.reonlyrun.CSharp25QExample.Example19.Lib02's Class1";
        }
    }
}


主单元（Program.cs）：
using System;
using System.Collections.Generic;
using System.Text;
//使用别名指示符解决同名类型的冲突
//在所有命名空间最外层定义，作用域为整个单元文件
using Lib01Class1 = com.nblogs.reonlyrun.CSharp25QExample.Example19.Lib01.Class1;
using Lib02Class2 = com.nblogs.reonlyrun.CSharp25QExample.Example19.Lib02.Class1;
namespace Example19
{
    namespace Test1
    {
        //Test1Class1在Test1命名空间内定义，作用域仅在Test1之内
        using Test1Class1 = com.nblogs.reonlyrun.CSharp25QExample.Example19.Lib01.Class1;
        class Class1
        {
            //Lib01Class1和Lib02Class2在这可以正常使用
            Lib01Class1 tmpObj1 = new Lib01Class1();
            Lib02Class2 tmpObj2 = new Lib02Class2();
            //TestClass1在这可以正常使用
            Test1Class1 tmpObj3 = new Test1Class1();
        }
    }
    namespace Test2
    {
        using Test1Class2 = com.nblogs.reonlyrun.CSharp25QExample.Example19.Lib01.Class1;
        class Program
        {
            static void Main(string[] args)
            {
                //Lib01Class1和Lib02Class2在这可以正常使用
                Lib01Class1 tmpObj1 = new Lib01Class1();
                Lib02Class2 tmpObj2 = new Lib02Class2();
                //注意这里，TestClass1在这不可以正常使用。因为，在Test2命名空间内不能使用Test1命名空间定义的别名
                //Test1Class1 tmpObj3 = new Test1Class1();
                //TestClass2在这可以正常使用
                Test1Class2 tmpObj3 = new Test1Class2();
                Console.WriteLine(tmpObj1);
                Console.WriteLine(tmpObj2);
                Console.WriteLine(tmpObj3);
                Console.ReadLine();
            }
        }
    }
}

// com.nblogs.reonlyrun.CSharp25QExample.Example19.Lib01's Class1
// com.nblogs.reonlyrun.CSharp25QExample.Example19.Lib02's Class1
// com.nblogs.reonlyrun.CSharp25QExample.Example19.Lib01's Class1

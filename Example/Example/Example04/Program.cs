using System;
using System.Collections.Generic;
using System.Text;

namespace Example04
{
    #region 基类，抽象类
    public abstract class BaseClass
    {
        //抽象属性，同时具有get和set访问器表示继承类必须将该属性实现为可读写
        public abstract String Attribute
        {
            get;
            set;
        }

        //抽象方法，传入一个字符串参数无返回值
        public abstract void Function(String value);

        //抽象事件，类型为系统预定义的代理(delegate)：EventHandler
        public abstract event EventHandler Event;

        //抽象索引指示器，只具有get访问器表示继承类必须将该索引指示器实现为只读
        public abstract Char this[int Index]
        {
            get;
        }
    }
    #endregion

    #region 继承类
    public class DeriveClass : BaseClass
    {
        private String attribute;
        public override String Attribute
        {
            get
            {
                return attribute;
            }
            set
            {
                attribute = value;
            }
        }
        public override void Function(String value)
        {
            attribute = value;
            if (Event != null)
            {
                Event(this, new EventArgs());
            }
        }

        public override event EventHandler Event;

        public override Char this[int Index]
        {
            get
            {
                return attribute[Index];
            }
        }
    }
    #endregion

    class Program
    {
        static void OnFunction(object sender, EventArgs e)
        {
            for (int i = 0; i < ((DeriveClass)sender).Attribute.Length; i++)
            {
                Console.WriteLine(((DeriveClass)sender)[i]);
            }
        }
        static void Main(string[] args)
        {
            DeriveClass tmpObj = new DeriveClass();
            tmpObj.Attribute = "1234567";
            Console.WriteLine(tmpObj.Attribute);
            //将静态函数 OnFunction 与 tmpObj 对象的 Event 事件进行关联
            tmpObj.Event += new EventHandler(OnFunction);
            tmpObj.Function("7654321");
            Console.ReadLine();
        }
    }
}

//1234567
//7
//6
//5
//4
//3
//2
//1

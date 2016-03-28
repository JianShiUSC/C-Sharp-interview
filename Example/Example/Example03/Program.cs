using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Example03
{
    class Program
    {
        //注意 DllImport 是一个 Attribute Property，在 System.Runtime.InteropServices 命名空间中定义
        //extern与DllImport一起使用时必须再加上一个static修饰符
        [DllImport("User32.dll")]
        public static extern int MessageBox(int Handle, string Message, string Caption, int Type);

        static int Main()
        {
            string myString;
            Console.Write("Enter your message: ");
            myString = Console.ReadLine();
            return MessageBox(0, myString, "My Message Box", 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Example22
{
    class Program
    {
        static void Main(string[] args)
        {
            const int cycle = 10000;
            long vTickCount = Environment.TickCount;
            String str = null;
            for (int i = 0; i < cycle; i++)
                str += i.ToString();
            Console.WriteLine("String: {0} MSEL", Environment.TickCount - vTickCount);

            vTickCount = Environment.TickCount;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cycle; i++)
                sb.Append(i);
            Console.WriteLine("StringBuilder: {0} MSEL", Environment.TickCount - vTickCount);

            string tmpStr1 = "A";
            string tmpStr2 = tmpStr1;
            Console.WriteLine(tmpStr1);
            Console.WriteLine(tmpStr2);
            //注意后面的输出结果，tmpStr1的值改变并未影响到tmpStr2的值
            tmpStr1 = "B";
            Console.WriteLine(tmpStr1);
            Console.WriteLine(tmpStr2);
            Console.ReadLine();
        }
    }
}

// String: 375 MSEL
// StringBuilder: 16 MSEL
// A
// A
// B
// A

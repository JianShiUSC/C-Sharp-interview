using System;
using System.Collections.Generic;
using System.Text;

namespace Example10
{
    class Class1
    {
        private double c;
        private string value;
        public double C
        {
            get{ return c; }
        }
        public Class1(double c)
        {
            //限定同名的隐藏成员
            this.c = c;
        }
        public Class1(Class1 value)
        {
            //用对象本身 实例化自己 没有意义
            if (this != value)
            {
                c = value.C;
            }
        }
        public override string ToString()
        {
            //将对象本身做为参数
            return string.Format("{0} Celsius = {1} Fahrenheit", c, UnitTransClass.C2F(this));
        }
    }
    class UnitTransClass
    {
        public static double C2F(Class1 value)
        {
            return 1.8 * value.C + 32;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 tmpObj = new Class1(37.5);
            Console.WriteLine(tmpObj);
            Console.ReadLine();
        }
    }
}



//37.5 Celsius = 99.5 Fahrenheit

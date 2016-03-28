using System;
using System.Collections.Generic;
using System.Text;

namespace Example07
{
    class Program
    {
        class BaseClass
        {
            public virtual void F()
            {
                Console.WriteLine("BaseClass.F");
            }
        }
        class DeriveClass : BaseClass
        {
            public override void F()
            {
                base.F();
                Console.WriteLine("DeriveClass.F");
            }
            public void Add(int Left, int Right)
            {
                Console.WriteLine("Add for Int: {0}", Left + Right);
            }
            public void Add(double Left, double Right)
            {
                Console.WriteLine("Add for int: {0}", Left + Right);
            }
        }
        static void Main(string[] args)
        {
            DeriveClass tmpObj = new DeriveClass();
            tmpObj.F();
            tmpObj.Add(1, 2);
            tmpObj.Add(1.1, 2.2);
            Console.ReadLine();
        }
    }
}


//BaseClass.F
//DeriveClass.F
//Add for Int: 3
//Add for int: 3.3

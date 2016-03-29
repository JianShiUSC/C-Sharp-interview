using System;
using System.Collections.Generic;
using System.Text;

namespace Example23
{
    class Program
    {
        class Immortal
        {
            public string name;
            public Immortal(string Name)
            {
                name = Name;
            }
            public static implicit operator Monster(Immortal value)
            {
                return new Monster(value.name + "：神仙变妖怪？隐式转换");
            }
        }
        class Monster
        {
            public string name;
            public Monster(string Name)
            {
                name = Name;
            }
            public static explicit operator Immortal(Monster value)
            {
                return new Immortal(value.name + "：妖怪想当神仙？显示转换");
            }
        }
        static void Main(string[] args)
        {
            Immortal tmpImmortal = new Immortal("紫霞仙子");    //隐式转换
            Monster tmpObj1 = tmpImmortal;
            Console.WriteLine(tmpObj1.name);

            Monster tmpMonster = new Monster("孙悟空");        //显式转换
            Immortal tmpObj2 = (Immortal)tmpMonster;
            Console.WriteLine(tmpObj2.name);
            Console.ReadLine();
        }
    }
}


// 紫霞仙子：神仙变妖怪？隐式转换
// 孙悟空：妖怪想当神仙？显示转换

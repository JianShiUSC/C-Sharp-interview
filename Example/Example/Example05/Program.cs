using System;
using System.Collections.Generic;
using System.Text;

namespace Example05Lib
{
    public class Class1
    {
        internal String strInternal = null;
        public String strPublic;
        internal protected String strInternalProtected = null;
    }
}


//Example05Lib 项目的 Class2 类可以访问到 Class1 的 strInternal 成员，当然也可以访问到 strInternalProtected 成员，因为他们在同一个程序集里
//Example05 项目里的 Class3 类无法访问到 Class1 的 strInternal 成员，因为它们不在同一个程序集里。但却可以访问到 strInternalProtected 成员，因为 Class3 是 Class1 的继承类
//Example05 项目的 Program 类既无法访问到 Class1 的 strInternal 成员，也无法访问到 strInternalProtected 成员，因为它们既不在同一个程序集里也不存在继承关系

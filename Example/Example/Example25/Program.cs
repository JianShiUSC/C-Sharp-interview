using System;
using System.Collections.Generic;
using System.Text;

namespace Example25Lib
{
    public class Class1
    {
        private string name;
        private int age;
        //如果显式的声明了无参数构造函数，客户端只需要用程序集的 CreateInstance 即可实例化该类
        //在此特意不实现，以便在客户调用端体现构造函数的反射实现
        //public Class1()
        //{
        //}
        public Class1(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
        public void ChangeName(string NewName)
        {
            name = NewName;
        }
        public void ChangeAge(int NewAge)
        {
            age = NewAge;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", name, age);
        }
    }
}

反射实例化对象并调用其方法，属性和事件的反射调用略去
using System;
using System.Collections.Generic;
using System.Text;
//注意添加该反射的命名空间
using System.Reflection;

namespace Example25
{
    class Program
    {
        static void Main(string[] args)
        {
            //加载程序集
            Assembly tmpAss = Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory + "Example25Lib.dll");
            //遍历程序集内所有的类型，并实例化
            Type[] tmpTypes = tmpAss.GetTypes();
            foreach (Type tmpType in tmpTypes)
            {
                //获取第一个类型的构造函数信息
                ConstructorInfo[] tmpConsInfos = tmpType.GetConstructors();
                foreach (ConstructorInfo tmpConsInfo in tmpConsInfos)
                {
                    //为构造函数生成调用的参数集合
                    ParameterInfo[] tmpParamInfos = tmpConsInfo.GetParameters();
                    object[] tmpParams = new object[tmpParamInfos.Length];
                    for (int i = 0; i < tmpParamInfos.Length; i++)
                    {
                        tmpParams[i] = tmpAss.CreateInstance(tmpParamInfos[i].ParameterType.FullName);
                        if (tmpParamInfos[i].ParameterType.FullName == "System.String")
                        {
                            tmpParams[i] = "Clark";
                        }
                    }
                    //实例化对象
                    object tmpObj = tmpConsInfo.Invoke(tmpParams);
                    Console.WriteLine(tmpObj);
                    //获取所有方法并执行
                    foreach (MethodInfo tmpMethod in tmpType.GetMethods())
                    {
                        //为方法的调用创建参数集合
                        tmpParamInfos = tmpMethod.GetParameters();
                        tmpParams = new object[tmpParamInfos.Length];
                        for (int i = 0; i < tmpParamInfos.Length; i++)
                        {
                            tmpParams[i] = tmpAss.CreateInstance(tmpParamInfos[i].ParameterType.FullName);
                            if (tmpParamInfos[i].ParameterType.FullName == "System.String")
                            {
                                tmpParams[i] = "Clark Zheng";
                            }
                            if (tmpParamInfos[i].ParameterType.FullName == "System.Int32")
                            {
                                tmpParams[i] = 27;
                            }
                        }
                        tmpMethod.Invoke(tmpObj, tmpParams);
                    }
                    //调用完方法后再次打印对象，比较结果
                    Console.WriteLine(tmpObj);
                }
            }
            Console.ReadLine();
        }
    }
}



// Name: Clark, Age: 0
// Name: Clark Zheng, Age: 27

using System;
using System.Collections.Generic;
using System.Text;

namespace Example20
{
    class Program
    {
        class Class1 : IDisposable
        {
            //析构函数，编译后变成 protected void Finalize()，GC会在回收对象前会调用该方法
            ~Class1()
            {
                Dispose(false);
            }

            //通过实现该接口，客户可以显式地释放对象，而不需要等待GC来释放资源，据说那样会降低效率
            void IDisposable.Dispose()
            {
                Dispose(true);
            }

            //将释放非托管资源设计成一个虚函数，提供在继承类中释放基类的资源的能力
            protected virtual void ReleaseUnmanageResources()
            {
                //Do something...
            }

            //私有函数用以释放非托管资源
            private void Dispose(bool disposing)
            {
                ReleaseUnmanageResources();
                //为true时表示是客户显式调用了释放函数，需通知GC不要再调用对象的Finalize方法
                //为false时肯定是GC调用了对象的Finalize方法，所以没有必要再告诉GC你不要调用我的Finalize方法啦
                if (disposing)
                {
                    GC.SuppressFinalize(this);
                }
            }
        }

        static void Main(string[] args)
        {
            //tmpObj1没有手工释放资源，就等着GC来慢慢的释放它吧
            Class1 tmpObj1 = new Class1();
            //tmpObj2调用了Dispose方法，传说比等着GC来释放它效率要调一些
            //个人认为是因为要逐个对象的查看其元数据，以确认是否实现了Dispose方法吧
            //当然最重要的是我们可以自己确定释放的时间以节省内存，优化程序运行效率
            Class1 tmpObj2 = new Class1();
            ((IDisposable)tmpObj2).Dispose();
        }
    }
}

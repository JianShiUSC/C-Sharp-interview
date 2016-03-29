class BaseClass
{
    public virtual void F()
    {
        Console.WriteLine("BaseClass.F");
    }
}

sealed class DeriveClass : BaseClass
{
    //基类中的虚函数F被隐式的转化为非虚函数
    //密封类中不能再声明新的虚函数G
    //public virtual void G()
    //{
    //    Console.WriteLine("DeriveClass.G");
    //}
}

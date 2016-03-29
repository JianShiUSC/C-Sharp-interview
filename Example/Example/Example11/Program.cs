class BaseClass
{
    public virtual void F()
    {
        Console.WriteLine("BaseClass.F");
    }
}

abstract class DeriveClass1 : BaseClass
{
    public abstract new void F();
}

//还可以用这种方法抽象重写基类的虚方法
abstract class DeriveClass2 : BaseClass
{
    public abstract override void F();
}

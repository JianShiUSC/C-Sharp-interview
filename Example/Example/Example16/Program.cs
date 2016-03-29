using System;
using System.Collections.Generic;
using System.Text;

namespace Example16
{
    interface IPoint
    {
        double X
        {
            get;
            set;
        }
        double Y
        {
            get;
            set;
        }
        double Z
        {
            get;
            set;
        }
    }

    //结构也可以从接口继承

    struct Point: IPoint
    {
        private double x, y, z;
        //结构也可以增加构造函数
        public Point(double X, double Y, double Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return x; }
            set { x = value; }
        }

        public double Z
        {
            get { return x; }
            set { x = value; }
        }
    }

    class PointGeometry
    {
        private Point value;
        public PointGeometry(double X, double Y, double Z)
        {
            value = new Point(X, Y, Z);
        }
        public PointGeometry(Point value)
        {
            //结构的赋值 将分配新的内存
            this.value = value;
        }
        public double X
        {
            get { return value.X; }
            set { this.value.X = value; }
        }
        public double Y
        {
            get { return value.Y; }
            set { this.value.Y = value; }
        }
        public double Z
        {
            get { return value.Z; }
            set { this.value.Z = value; }
        }
        public static PointGeometry operator +(PointGeometry Left, PointGeometry Right)
        {
            return new PointGeometry(Left.X + Right.X, Left.Y + Right.Y, Left.Z + Right.Z);
        }
        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}, Z: {2}", value.X, value.Y, value.Z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point tmpPoint = new Point(1, 2, 3);
            PointGeometry tmpPG1 = new PointGeometry(tmpPoint);
            PointGeometry tmpPG2 = new PointGeometry(tmpPoint);
            tmpPG2.X = 4;
            tmpPG2.Y = 5;
            tmpPG2.Z = 6;
            //由于结构是值类型，tmpPG1 和 tmpPG2 的坐标并不一样
            Console.WriteLine(tmpPG1);
            Console.WriteLine(tmpPG2);
            //由于类是引用类型，对tmpPG1坐标修改后影响到了tmpPG3
            PointGeometry tmpPG3 = tmpPG1;
            tmpPG1.X = 7;
            tmpPG1.Y = 8;
            tmpPG1.Z = 9;
            Console.WriteLine(tmpPG1);
            Console.WriteLine(tmpPG3);
            Console.ReadLine();
        }
    }
}


// X: 1, Y: 2, Z: 3
// X: 4, Y: 5, Z: 6
// X: 7, Y: 8, Z: 9
// X: 7, Y: 8, Z: 9

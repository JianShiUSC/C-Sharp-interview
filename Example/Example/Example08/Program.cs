using System;
using System.Collections.Generic;
using System.Text;

namespace Example08
{
    public class Point
    {
        private double x, y;
        public Point(double X, double Y)
        {
            x = X;
            y = Y;
        }
        //重写ToString方法方便输出
        public override string ToString()
        {
            return String.Format("X: {0} , Y: {1}", x, y);
        }
    }

    public class Points
    {
        Point[] points;
        public Points(Point[] Points)
        {
            points = Points;
        }
        public int PointNumber
        {
            get
            {
                return points.Length;
            }
        }
        //实现索引访问器
        public Point this[int Index]
        {
            get
            {
                return points[Index];
            }
        }
    }

    //感谢watson hua(http://huazhihao.cnblogs.com/)的指点

    //索引指示器的实质是含参属性，参数并不只限于int

    class WeatherOfWeek
    {
        public string this[int Index]
        {
            get
            {
                //注意case段使用return直接返回所以不需要break
                switch (Index)
                {
                    case 0:
                        {
                            return "Today is cloudy!";
                        }
                    case 5:
                        {
                            return "Today is thundershower!";
                        }
                    default:
                        {
                            return "Today is fine!";
                        }
                }
            }
        }
        public string this[string Day]
        {
            get
            {
                string TodayWeather = null;
                //switch的标准写法
                switch (Day)
                {
                    case "Sunday":
                        {
                            TodayWeather = "Today is cloudy!";
                            break;
                        }
                    case "Friday":
                        {
                            TodayWeather = "Today is thundershower!";
                            break;
                        }
                    default:
                        {
                            TodayWeather = "Today is fine!";
                            break;
                        }
                }
                return TodayWeather;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point[] tmpPoints = new Point[10];
            for (int i = 0; i < tmpPoints.Length; i++)
            {
                tmpPoints[i] = new Point(i, Math.Sin(i));
            }

            Points tmpObj = new Points(tmpPoints);
            for (int i = 0; i < tmpObj.PointNumber; i++)
            {
                Console.WriteLine(tmpObj[i]);
            }

            string[] Week = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Staurday"};
            WeatherOfWeek tmpWeatherOfWeek = new WeatherOfWeek();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(tmpWeatherOfWeek[i]);
            }
            foreach (string tmpDay in Week)
            {
                Console.WriteLine(tmpWeatherOfWeek[tmpDay]);
            }
            Console.ReadLine();
        }
    }
}

// 结果：
// X: 0 , Y: 0
// X: 1 , Y: 0.841470984807897
// X: 2 , Y: 0.909297426825682
// X: 3 , Y: 0.141120008059867
// X: 4 , Y: -0.756802495307928
// X: 5 , Y: -0.958924274663138
// X: 6 , Y: -0.279415498198926
// X: 7 , Y: 0.656986598718789
// X: 8 , Y: 0.989358246623382
// X: 9 , Y: 0.412118485241757
// Today is cloudy!
// Today is fine!
// Today is fine!
// Today is fine!
// Today is fine!
// Today is thundershower!
// Today is cloudy!
// Today is fine!
// Today is fine!
// Today is fine!
// Today is fine!
// Today is thundershower!
// Today is fine!

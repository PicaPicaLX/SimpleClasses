using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 提要：通过为一家汽车经销商开发一套能够根据车辆品牌型号生产日期
 * 进行估值或交易的软件来理解"类(class)"的使用，并创建自定义类来完成学习
 * 下面演示比较高效的方法，即手创建一个自定义类:Car
 * 当你想增加车辆属性(或新车辆)时，不需要手动在车辆数据中添加新条目
 * 只需要在类的外部创建新变量即可
 */
namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car(); // 在Car类中新建myCar1变量
            myCar1.Make = "Oldsmobile"; // 在myCar1变量下新建子变量myCar1.Make，描述myCar1的一个性质
            myCar1.Model = "Cutlas Supreme"; // ~
            myCar1.Year = 1986; // ~
            myCar1.Color = "Silver"; // ~

            Car myCar2 = new Car(); // 在Car类中新建myCar2变量
            myCar2.Make = "New"; // 在myCar2变量下新建子变量myCar2.Make，描述myCar的一个性质
            myCar2.Model = "Buick"; // ~
            myCar2.Year = 1999; // ~
            myCar2.Color = "Black"; // ~

            Console.WriteLine("{0} {1} {2} {3}",
                myCar1.Make, 
                myCar1.Model, 
                myCar1.Year, 
                myCar1.Color); // 显示变量myCar1的一系列子变量，

            //decimal value = myCar1.DetermineMarketValue(); // 在Car类中调用方公共法D.M.V.计算myCar1价值，以美元显示
            //Console.WriteLine("{0:c}",value);

            // 下面是一种新的写法
            Console.WriteLine("Car Value: {0:c}", myCar2.DetermineMarketValue()); // 在Car类中调用方公共法D.M.V.计算myCar2价值，以美元显示
            Console.ReadLine();
        }
    }


    class Car // 自定义的Car类
    {
        public string Make { get; set; } // 定义一个公共字符串型变量Make
        public string Model { get; set; } // 定义一个公共字符串型变量Model
        public int Year { get; set; } // 定义一个公共整数型变量Year
        public string Color { get; set; } // 定义一个公共字符串型变量Color

        public decimal DetermineMarketValue() // 自定义的公共方法DeterminMarketValue(), decimal表示整数型变量
        {
            decimal carValue;
            if (Year>1990)
                carValue = 10000;            
            else
                carValue = 2000;
            return carValue;
        }
    }
}

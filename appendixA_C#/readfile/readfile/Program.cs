using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 存储文件的路径和文件名
            string file = "d:\\test.dat";

            // 判断test.dat文件是否存在
            if (System.IO.File.Exists(file))
            {
                // 用于存储读入的数据
                string[] data = new string[2];

                // 将C盘的test.dat文件中的数据读出
                data = System.IO.File.ReadAllLines(file);

                // 打印数据
                Console.WriteLine(data[0]);
                Console.WriteLine(data[1]);
            }

            // 输入任意键退出
            Console.ReadKey();
        }
    }
}

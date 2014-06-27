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

            string[] data = new string[2];
            data[0] = "第一条信息";
            data[1] = "第二条信息";

            // 将两条数据写入C盘的test.dat文件中
            System.IO.File.WriteAllLines(file, data);

            // 输入任意键退出
            Console.ReadKey();
        }
    }
}

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

            // 需要存储的数据
            int data1 = 100;
            float data2 = 0.1f;

            // 记录数据的位置
            int index = 0;

            // 用于存储所有数据的byte数组
            byte[] bytes = new byte[256];

            // 将data1转为byte数组
            byte[] b = BitConverter.GetBytes(data1);

            // 将data1数据存入bytes数组中
            b.CopyTo(bytes, index);

            // 一个int类型占4个byte
            index += 4;

            // 将data1转为byte数组
            b = BitConverter.GetBytes(data2);

            // 将data2数据存入bytes数组中
            b.CopyTo(bytes, index);

            // 一个float类型占4个byte
            index += 4;

            // 将数据保储到d:\\test.dat
            System.IO.File.WriteAllBytes(file, bytes);

            // 判断test.dat文件是否存在
            if (System.IO.File.Exists(file))
            {
                bytes = new byte[256];

                // 读入数据
                bytes = System.IO.File.ReadAllBytes(file);

                // 取出头4个字节作为int
                int readdata1 = BitConverter.ToInt32(bytes, 0);

                // 再取出4个字节作为float
                float readdata2 = BitConverter.ToSingle(bytes, 4);

                // 打印数据
                Console.WriteLine(readdata1);
                Console.WriteLine(readdata2);
            }

            // 输入任意键退出
            Console.ReadKey();
        }
    }
}

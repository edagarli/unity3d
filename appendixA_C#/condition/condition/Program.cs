using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        // 定义枚举
        enum FRUID
        {
            Apple = 0,
            Banana,
            Cherry,
        }
        static FRUID fruid = FRUID.Apple;

        static void Main(string[] args)
        {
            switch (fruid)
            {
                case FRUID.Apple:	// 如果fruid的值等于FRUID.Apple
                    Console.WriteLine("apple");
                    break;// 使用break退出

                case FRUID.Banana:
                    Console.WriteLine("Banana");
                    break;

                case FRUID.Cherry:
                    Console.WriteLine("Cherry");
                    break;
            }

            // 以上switch语句等同于
            if (fruid == FRUID.Apple)
                 Console.WriteLine("apple");
            else if (fruid == FRUID.Banana)
                Console.WriteLine("Banana");
            else if (fruid == FRUID.Cherry)
                Console.WriteLine("Cherry");

            Console.ReadKey(); // 按任意键退出
        }
    }
}


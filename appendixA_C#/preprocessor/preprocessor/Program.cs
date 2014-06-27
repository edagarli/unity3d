#define DEBUG // 定义预处理标识符DEBUG,必须声明在using关键字之前

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

#if TEST
            // 因为未定义预处理标识符TEST,这里的代码不会被编译
		  // do something…
#elif DEBUG
            // 定义了DEBUG,这里的代码将会被编译
            Console.WriteLine("DEBUG");
#else
            //这里的代码不会出现在最终程序中,不会被编译
		  // do something…
#endif

#if TEST || DEBUG
            // 只要定义了预处理标识符TEST或DEBUG中的任意一个,即可编译这里
            Console.WriteLine("TEST || DEBUG");
#endif

#if !TEST
            // 如果没有定义预处理标识符TEST,编译这里
            Console.WriteLine("!TEST");
#endif

            // 输入任意键退出
            Console.ReadKey();
        }
    }
}


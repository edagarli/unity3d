using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
   
    public class ImplementingClass
    {
        // 2. 定义用于委托调用的方法，它的返回值和参数列表必须与委托一致
        public int WhichIsBig(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public int WhichIsSmall(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }
    }

    class Program
    {
        // 1. 用delegate关键字声明一个委托，定义它的返回值和参数列表（方法签名）
        public delegate int CallDelegate(int a, int b);

        // 在函数内使用委托
        public static int Process(int a, int b, CallDelegate call)
        {
            return call(a, b);
        }

        static void Main(string[] args)
        {
            // 3. 在程序中创建委托实例与步骤2创建的方法相关联
            CallDelegate delegateBig = new CallDelegate(new ImplementingClass().WhichIsBig);

            // 4. 用委托调用相关联的方法,执行ImplementingClass WhichIsBig
            int big = delegateBig(10, 20);

            // 另一种使用委托的方式, 执行ImplementingClass WhichIsSmall
            int small = Process(10, 20, new CallDelegate(new ImplementingClass().WhichIsSmall));

            // 输出
            Console.WriteLine(big);     // 输出最大值20
            Console.WriteLine(small);   // 输出最小值10

            // 输入任意键退出
            Console.ReadKey();
        }
    }
}

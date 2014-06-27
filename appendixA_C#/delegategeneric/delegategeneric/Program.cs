using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    
    public class ImplementingClass
    {
        // 定义委托调用的方法
        public float WhichIsBig(int a, float b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }

    class Program
    {
        // 定义一个泛型委托,它的参数可以是任意类型
        public delegate float CallDelegate<T, S>(T t, S s);

        static void Main(string[] args)
        {
            //实例化委托
            CallDelegate<int, float> delegateBig = new CallDelegate<int, float>(new ImplementingClass().WhichIsBig);

            //调用委托方法,执行ImplementingClass WhichIsBig
            float big = delegateBig(10, 20.5f);

            // 输出最大值20.5
            Console.WriteLine(big);

            // 输入任意键退出
            Console.ReadKey();
        }
    }
}

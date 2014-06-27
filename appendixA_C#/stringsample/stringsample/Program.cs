using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个字符串
            string str1 = "apple orange banana";
            Console.WriteLine("str1:" + str1);

            // 创建另一个字符串
            string str2 = str1 + " peach";
            Console.WriteLine("str2:" + str2);

            // 比较两个字符串是否一致
            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine("str1和str2两个字符串一致");
            }
            else
            {
                Console.WriteLine("str1和str2两个字符串不一致");
            }

            // 从第0个字节开始查找空格的位置
            int n = str1.IndexOf(' ', 0);
            Console.WriteLine("str1第一个空格在第{0}个字节", n);

            // 删除第1个空格之后的所有字符
            str2 = str1.Remove(n);
            Console.WriteLine("删除str1第一个空格后的所有字符:" + str2);

            // 将所有空格替换为-
            str2 = str1.Replace(' ', '-');
            Console.WriteLine("将str1所有空格替换为-:" + str2);

            // 在第一个空格之后插入@@@
            str2 = str1.Insert(n, " peach");
            Console.WriteLine("在str1第一个空格后插入 peach:" + str2);

            // 取第一个空格后的6个字符
            str2 = str1.Substring(n + 1, 6);
            Console.WriteLine("取str1第一个空格后的6个字符:" + str2);

            // 以空格为标识符,将字符串分解为若干个新的字符串
            char[] chars = { ' ' };
            string[] strs = str1.Split(chars);

            Console.WriteLine("以空格为标识符,将str1分解为:");
            for (int i = 0; i < strs.Length; i++)
                Console.WriteLine(i + ":" + strs[i]);

            // 输入任意键退出
            Console.ReadKey();
        }
    }
}


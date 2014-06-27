using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class Player
    {
        public static int count = 0; //静态成员,用于统计Player对象的数量

        public Player()
        {
            count++; // 每创建一个Player对象,count自加一次
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(); //创建一个Player对象
            Console.WriteLine(Player.count);// 输出1,有1个Player

            Player player2 = new Player();// 又创建一个Player对象
            Console.WriteLine(Player.count); // 输出2,有2个Player

            // n = player2.count; 错误用法,静态成员不能被对象直接调用

            // 输入任意键退出
            Console.ReadKey();
        }
    }
}

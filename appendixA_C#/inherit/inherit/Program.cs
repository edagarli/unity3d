using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    // 定义一个叫Enemy的基类
    public class Enemy
    {
        //构造函数
        public Enemy()
        {
            Console.WriteLine("enemy contructor");
        }

        // 声明为虚方法
        public virtual void UpdateAI()
        {
            // Enemy的AI
            Console.WriteLine("update enemy ai");
        }
    }

    // 派生类Boss继承自基类Enemy,
    public class Boss : Enemy
    {
        //构造函数
        public Boss()
        {
            Console.WriteLine("boss contructor");
        }

        //添加override，代替基类的方法
        public override void UpdateAI()
        {
            // Boss 的AI
            Console.WriteLine("update boss ai");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Enemy[] enemies = new Enemy[2]; //创建一个数组,包括两个Enemy基类
            enemies[0] = new Enemy();       //创建一个Enemy, 执行Enemy的构造函数
            enemies[1] = new Boss();        //创建一个Boss,先执行Enemy的构造函数,再执行Boss的

            for (int i = 0; i < 2; i++)
            {
                // enemies[0]会调用Enemy类的UpdateAI
                // enemies[1]会调用Boss类的UpdateAI
                enemies[i].UpdateAI();
            }

            // 输入任意键退出
            Console.ReadKey();
        }
    }
}

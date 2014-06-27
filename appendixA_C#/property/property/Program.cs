using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class Player
    {
        private string m_name = ""; //私有, 不能直接访问
        public string Name
        {
            set { m_name = value; } //通过访问Name属性改变m_name的值
            get { return m_name; } //通过访问Name属性获得m_name的值
        }

        private int m_life = 100; //私有,不能直接访问
        public int Life
        {
            get { return m_life; } //通过访问Life属性获得m_life的值
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Name = "player1";    //OK
            //player.Life = 10; 	    //错误,Life是只读属性

            Console.WriteLine(player.Name); // 输出Name
            Console.WriteLine(player.Life);  // 输出Life的值100

            // 输入任意键退出
            Console.ReadKey();
        }
    }
}

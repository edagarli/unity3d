using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        // 1. 定义一个类，继承EventArgs，它用于存储事件中需要传递的数据
        public class NetworkEventArgs : EventArgs
        {
            // 网络数据
            public string stream = "";
        }

        // "网络管理器"
        public class NetworkManager
        {
            // 2. 使用delegate为发送者定义一个委托，返回类型为void，两个参数
            public delegate void ProcessNetwork(object sender, NetworkEventArgs e);

            // 3. 使用event为发送者定义一个事件
            public event ProcessNetwork DownloadEvent;

            // 4. 为发送者定义事件”下载完成”的方法
            public void DownloadContent()
            {
                // 将下载的信息传给NetworkEventArgs
                NetworkEventArgs downloadEvent = new NetworkEventArgs();
                downloadEvent.stream = "CONTENT";

                // 发送消息给"消息接收器"
                DownloadEvent(this, downloadEvent);
            }
        }

        // "消息接收器"
        public class EventReceiver
        {
            // 5. 构造函数, 为接收者创建委托实例与事件相关联
            public EventReceiver(NetworkManager network)
            {
                // 产生一个委托实例,当事件完成时会触发OnDownloaded方法
                network.DownloadEvent += new NetworkManager.ProcessNetwork(this.OnDownloaded);
            }

            //6. 为接收者定义实际处理事件的方法
            protected virtual void OnDownloaded(object sender, NetworkEventArgs e)
            {
                Console.WriteLine("下载完成: {0}", e.stream);
            }
        }

        static void Main(string[] args)
        {
            // 7. 在主程序中创建事件发送者实例,创建一个"网络管理器"
            NetworkManager network = new NetworkManager();

            // 8. 创建一个接收者实例"消息接收器",处理来自发送者"网络管理器"发来的消息
            EventReceiver eventReceiver = new EventReceiver(network);

            // "网络管理器"触发下载完成消息
            network.DownloadContent();

            // 输入任意键退出
            Console.ReadKey();
        }
    }

}

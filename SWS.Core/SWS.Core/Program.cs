//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Shaoye!");


using SWS.Core;

class Program
{
    public static void Main(string[] args)
    {
        #region 接口练习题测试
        //Computer computer = new Computer();
        //StorageDivice hd = new StorageDivice("硬盘");
        //StorageDivice ud = new StorageDivice("U盘");
        //MP3 mP3 = new MP3();
        //computer.uSB = hd;
        //computer.uSB.TransferData();
        //computer.uSB = ud;
        //computer.uSB.TransferData();
        //computer.uSB = mP3;
        //computer.uSB.TransferData();
        //mP3.PlayBack();
        #endregion
        Console.WriteLine("给DeepSeek发送消息:");
        while (true)
        {
            string input = Console.ReadLine();
            int randomWaiting = new Random().Next(10000, 40000);
            Console.WriteLine("\n思考中...");
            Thread.Sleep(randomWaiting);
            Console.WriteLine("服务器繁忙，请稍后再试。");
        }
    }
}


//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Shaoye!");


class Program
{
    public static void Main(string[] args)
    {
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


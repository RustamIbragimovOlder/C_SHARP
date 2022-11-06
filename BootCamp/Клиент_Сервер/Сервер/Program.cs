namespace Server // пространство имен для связи файлов
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это наш сервер");
            OurServer server = new OurServer();            
        }
    }
}

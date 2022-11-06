using System.Net.Sockets;
using System.Text;

namespace Client // пространство имен для связи файлов
{
    class OurClient
    {
        private TcpClient client;
        private StreamWriter sWriter;
        private StreamReader sReader;

        public OurClient()
        {
            // подключение к серверу
            client = new TcpClient("127.0.0.1", 5555);
            sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);
            sReader = new StreamReader(client.GetStream(), Encoding.UTF8);

            HandleCommunication();
        }

        // Метод поддержания соединения TCP
        void HandleCommunication()
        {
            while (true) // бесконечный цикл
            {
                Console.Write("> ");
                string message = Console.ReadLine();
                sWriter.WriteLine(message);
                sWriter.Flush();
                string answerServer = sReader.ReadLine();
                Console.WriteLine($"Сервер ответил -> {answerServer}");
            }
        }
    }
}
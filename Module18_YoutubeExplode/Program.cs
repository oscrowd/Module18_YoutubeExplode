using Module18_YoutubeExplode;

class Program
{
    static void Main()
    {
        string videoUrl = "https://www.youtube.com/watch?v=bk6i4IQ3b54";
        // создадим отправителя
        var sender = new Sender();

        // создадим получателя
        var receiver = new Receiver();

        // создадим команду
        var commandOne = new CommandOne(receiver);

        // инициализация команды
        sender.SetCommand(commandOne);


        //  выполнение
        sender.GetInfo(videoUrl);
        sender.Download(videoUrl);
        Console.ReadLine();
    }
}
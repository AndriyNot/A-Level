namespace HomeWork10
{
    using HomeWork10.Models;
    using HomeWork10.Service;

    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            FileService fileService = new FileService("Logs");
            Actions actions = new Actions(logger);
            App app = new App(actions, logger, fileService);

            app.Run();
        }
    }
}

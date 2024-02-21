namespace HomeWork16
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            TextReader textReader = new TextReader();
            string concatenatedText = await textReader.ConcatenateTextAsync();

            Console.WriteLine(concatenatedText);
        }

    }
}

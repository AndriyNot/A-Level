namespace HomeWork16
{
    public class TextReader
    {
        public async Task<string> ReadHelloFile()
        {
            string filePathHello = "Hello.txt";
            return await ReadFromFileAsync(filePathHello);
        }

        public async Task<string> ReadWorldFile()
        {
            string filePathWorld = "World.txt";
            return await ReadFromFileAsync(filePathWorld);
        }

        public async Task<string> ConcatenateTextAsync()
        {
            Task<string> helloTask = ReadHelloFile();
            Task<string> worldTask = ReadWorldFile();

            await Task.WhenAll(helloTask, worldTask);

            return helloTask.Result + "\n" + worldTask.Result;
        }

        private async Task<string> ReadFromFileAsync(string file)
        {
            string result = "";

            try
            {
                using(StreamReader reader = new StreamReader(file))
                {
                    result = await reader.ReadToEndAsync();
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error file not found:{file}, {ex.Message}");
            }

            return result;
        }

       
    }
}

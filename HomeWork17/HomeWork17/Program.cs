namespace HomeWork17.MessageBox
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            MessageBox messageBox = new MessageBox();
            messageBox.WindowClosed += MessageWindowClosed;
            await messageBox.Open();
        }

        private static void MessageWindowClosed(object sender, WindowStateEventArgs e) 
        {
            if (e.WindowState == State.Ok)
            {
                Console.WriteLine("Operation confirmed ");
            }
            else
            {
                Console.WriteLine("Operation rejected ");
            }
        }
    }
}

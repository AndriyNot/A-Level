namespace HomeWork17.MessageBox
{
    public class MessageBox
    {
        private SemaphoreSlim semaphore = new SemaphoreSlim(1);
        public event EventHandler<WindowStateEventArgs> WindowClosed;

        public async Task Open()
        {
            await semaphore.WaitAsync();

            Console.WriteLine("Window open");
            await Task.Delay(3000);
            Console.WriteLine("Window was clossed by the user");

            var random = new Random();
            var state = random.Next(2) == 0 ? State.Ok : State.Cancel;

            OnWindowClosed(state);

            semaphore.Release();
        }

        public virtual void OnWindowClosed(State state)
        {
            WindowClosed.Invoke(this, new WindowStateEventArgs(state));
        }
    }
}

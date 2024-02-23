namespace HomeWork17.MessageBox
{
    public class WindowStateEventArgs
    {
        public State WindowState { get; set; } 

        public WindowStateEventArgs(State windowState) 
        {
            WindowState = windowState;
        }

    }
}

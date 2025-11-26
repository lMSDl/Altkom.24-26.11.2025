namespace DesignPatterns.Behavioral.Command
{
    internal class CommandInvoker
    {
        private readonly static Stack<ICommand> _commandsHistory = new(); 
        private readonly ICommand _command;
        public CommandInvoker(ICommand command)
        {
            _command = command;
        }

        public void Click()
        {
            if (_command.Execute())
            {
                _commandsHistory.Push(_command);
            }
        }

        public static void Reverse()
        {
            if (_commandsHistory.TryPop(out var lastCommand))
            {
                lastCommand.Undo();
            }
        }
    }
}

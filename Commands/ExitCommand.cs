using System;

namespace Figure_Calculator.Commands
{
    class ExitCommand : ICommand
    {
        public ExitCommand(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public void Execute(string data)
        {
            Environment.Exit(0);
        }
    }
}

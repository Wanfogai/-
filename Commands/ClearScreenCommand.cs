using static System.Console;

namespace Figure_Calculator.Commands
{
    class ClearScreenCommand : ICommand
    {
        public string Name { get; }
        public ClearScreenCommand(string name)
        {
            Name = name;
        }
        public void Execute(string data)
        {
            Clear();
        }
    }
}

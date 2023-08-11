namespace Figure_Calculator
{
    interface ICommand
    {
        string Name { get; }
        void Execute(string data);
    }
}

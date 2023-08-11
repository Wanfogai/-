using System.Collections.Generic;
using static System.Console;

namespace Figure_Calculator.Commands
{
    class AllPerimetrCommand : ICommand
    {
        public AllPerimetrCommand(string name, List<Shape> shapes)
        {
            Name = name;
            Shapes = shapes;
        }
        public string Name { get; }
        public List<Shape> Shapes { get; set; }
        public void Execute(string data)
        {
            double AllPerimetr = 0;
            if (Shapes.Count == 0) WriteLine("У вас нет фигур :(");
            else
            {
                for (int i = 0; i < Shapes.Count; i++)
                {
                    AllPerimetr += Shapes[i].Perimeter();
                }
                WriteLine($"Площадь всех фигур : {AllPerimetr}");
            }
        }
    }
}

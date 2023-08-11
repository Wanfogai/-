using System;
using System.Collections.Generic;
using static System.Console;

namespace Figure_Calculator.Commands
{
    class AddSquareCommand : ICommand
    {
        public AddSquareCommand(string name, List<Shape> shapes)
        {
            Name = name;
            Shapes = shapes;
        }
        public string Name { get; }
        public List<Shape> Shapes { get; set; }
        public void Execute(string data)
        {
            data = data.Replace('.', ',');
            Shapes.Add(new Square(Convert.ToDouble(data)));
            WriteLine($"Фигура Квадрат успешно добавлена!");
        }
    }
}

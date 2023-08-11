using System;
using System.Collections.Generic;
using static System.Console;

namespace Figure_Calculator.Commands
{
    class AddCircleCommand : ICommand
    {
        public AddCircleCommand(string name, List<Shape> shapes)
        {
            Name = name;
            Shapes = shapes;
        }
        public string Name { get; }
        public List<Shape> Shapes { get; set; }
        public void Execute(string data)
        {
            data = data.Replace('.', ',');
            Shapes.Add(new Circle(Convert.ToDouble(data)));
            WriteLine($"Фигура Круг успешно добавлена!");
        }
    }
}

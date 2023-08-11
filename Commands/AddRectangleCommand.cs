using System;
using System.Collections.Generic;
using static System.Console;

namespace Figure_Calculator.Commands
{
    class AddRectangleCommand : ICommand
    {
        public AddRectangleCommand(string name, List<Shape> shapes)
        {
            Name = name;
            Shapes = shapes;
        }
        public string Name { get; }
        public List<Shape> Shapes { get; set; }
        public void Execute(string data)
        {
            data = data.Replace(',', ' ');
            data = data.Replace('.', ',');
            string[] sides = data.Split();
            Shapes.Add(new Rectangle(Convert.ToDouble(sides[0]), Convert.ToDouble(sides[1])));
            WriteLine($"Фигура Прямоугольник успешно добавлена!");
        }
    }
}

using System;
using System.Collections.Generic;
using static System.Console;

namespace Figure_Calculator.Commands
{
    class AddTriangleCommand : ICommand
    {
        public AddTriangleCommand(string name, List<Shape> shapes)
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
            Triangle triangle = new Triangle(Convert.ToDouble(sides[0]), Convert.ToDouble(sides[1]), Convert.ToDouble(sides[2]));
            if (triangle.IsValidate())
            {
                Shapes.Add(triangle);
                WriteLine($"Фигура Треугольник успешно добавлена!");
            }
            else WriteLine("Данный треугольник не может существовать ");
        }
    }
}

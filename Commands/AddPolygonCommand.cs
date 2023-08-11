using Figure_Calculator.Shapes;
using System;
using System.Collections.Generic;
using static System.Console;

namespace Figure_Calculator.Commands
{
    class AddPolygonCommand : ICommand
    {
        public AddPolygonCommand(string name, List<Shape> shapes)
        {
            Name = name;
            Shapes = shapes;
        }
        public string Name { get; }
        public List<Shape> Shapes { get; set; }

        public void Execute(string data)
        {
            data = data.Insert(data.Length, " ");
            data = data.Replace(',', ' ');
            data = data.Replace('.', ',');
            List<Point> Points = new List<Point> { };
            Polygon polygon = null;

            while (data.Length > 0)
            {
                double X = Convert.ToDouble(data.Substring(0, data.IndexOf(' ') + 1));
                data = data.Remove(0, data.IndexOf(' ') + 1);
                double Y = Convert.ToDouble(data.Substring(0, data.IndexOf(' ') + 1));
                data = data.Remove(0, data.IndexOf(' ') + 1);
                Points.Add(new Point(X, Y));
            }
            polygon = new Polygon(Points);

            /*if (Points.Count < 5)
                WriteLine("Недостаточно углов для многоугольника");
            else*/ if (!polygon.IsValidate()) 
                WriteLine("Точки не могут повтаряться");
            else
            {
                Shapes.Add(polygon);
                WriteLine($"Фигура Многоугольник успешно добавлена!");
            }
        }

    }
}

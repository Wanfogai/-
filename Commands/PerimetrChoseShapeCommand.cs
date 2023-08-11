using System;
using System.Collections.Generic;
using static System.Console;

namespace Figure_Calculator.Commands
{
    class PerimetrChoseShapeCommand : ICommand
    {
        public PerimetrChoseShapeCommand(string name, List<Shape> shapes)
        {
            Shapes = shapes;
            Name = name;
        }
        public string Name { get; }
        public List<Shape> Shapes { get; set; }
        public void Execute(string data)
        {
            try
            {
                WriteLine($"Периметр {Shapes[Convert.ToInt32(data) - 1].Name}а : {(Shapes[Convert.ToInt32(data) - 1].Perimeter()):f2}");
            }
            catch (Exception)
            {

                WriteLine("Фигура не найдена");
            }
        }
    }
}

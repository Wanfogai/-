using System;
using System.Collections.Generic;
using static System.Console;

namespace Figure_Calculator.Commands
{
    class AreaChoseShapeCommand : ICommand
    {
        public AreaChoseShapeCommand(string name, List<Shape> shapes)
        {
            Name = name;
            Shapes = shapes;
        }
        public string Name { get; }
        public List<Shape> Shapes { get; set; }
        public void Execute(string data)
        {
            try
            {
                WriteLine($"Площадь  {Shapes[Convert.ToInt32(data) - 1].Name}а : {(Shapes[Convert.ToInt32(data) - 1].Area()):f2}");
            }
            catch (Exception)
            {
                WriteLine("Фигура не найдена");
            }
        }
    }
}

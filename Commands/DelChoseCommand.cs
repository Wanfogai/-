using System;
using System.Collections.Generic;
using static System.Console;

namespace Figure_Calculator.Commands
{
    class DelChoseCommand : ICommand
    {
        public DelChoseCommand(string name, List<Shape> shapes)
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
                WriteLine($"Фигура {Shapes[Convert.ToInt32(data) - 1].Name} успешно удалена");
                Shapes.RemoveAt(Convert.ToInt32(data) - 1);
            }
            catch (Exception)
            {
                WriteLine("Не удалось удалить фигуру");
                throw;
            }
        }
    }
}

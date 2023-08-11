using System;
using System.Collections.Generic;
using static System.Console;

namespace Figure_Calculator.Commands
{
    class ClearListCommand : ICommand
    {
        public ClearListCommand(string name, List<Shape> shapes)
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
                Shapes.Clear();
                WriteLine("Фигуры успешно очищены");
            }
            catch (Exception)
            {
                WriteLine("Не удалось очистить фигуры");
                throw;
            }
        }
    }
}

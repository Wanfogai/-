using Figure_Calculator.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Figure_Calculator
{
    class App
    {
        public List<Shape> Shapes { get; set; }
        public List<ICommand> Commands { get; set; }
        /// <summary>
        /// Метод инициализации первоначальных данных
        /// </summary>
        public void Init()
        {
            Shapes = new List<Shape>() { };
            Commands = new List<ICommand>
            {
                new AddCircleCommand("добавить круг",Shapes),
                new AddSquareCommand("добавить квадрат",Shapes),
                new AddTriangleCommand("добавить треугольник",Shapes),
                new AddRectangleCommand("добавить прямоугольник",Shapes),
                new AddPolygonCommand("добавить многоугольник",Shapes),
                new ShowAllShapesCommand("вывести фигуры",Shapes),
                new AreaChoseShapeCommand("площадь фигуры",Shapes),
                new PerimetrChoseShapeCommand("периметр фигуры",Shapes),
                new AllAreaCommand("площадь всех",Shapes),
                new AllPerimetrCommand("периметр всех",Shapes),
                new ClearListCommand("очистить список",Shapes),
                new DelChoseCommand("удалить фигуру",Shapes),
                new SaveAllShapesCommand("сохранить фигуры",Shapes),
                new LoadAllShapesCommand("загрузить фигуры",Shapes),
                new HelpCommand("помощь"),
                new ClearScreenCommand("очистить консоль"),
                new ExitCommand("выход"),
            };

        }
        /// <summary>
        /// Функция старта программы
        /// </summary>
        public void Run()
        {
            WriteLine("Добро пожаловать в \"Калькулятор фигур\"");
            WriteLine("Введите \"Помощь\" для информации о командах");

            while (true)
            {
                (string, string) Command = this.Command();
                try
                {
                    Commands.FirstOrDefault(x => x.Name == Command.Item1.ToLower()).Execute(Command.Item2);
                }
                catch (Exception)
                {
                    WriteLine("Не удалось выполнить комманду");
                }
            }
        }
        private (string, string) Command()
        {
            Write("Комманда : ");
            string command = ReadLine();
            return (command.Split()[0] + ((command.Split().Length > 1) ? " " + command.Split()[1] : ""),
                    command.Split().Length > 2 ? command.Substring(command.IndexOf(command.Split()[2])) : "");
        }
    }
}

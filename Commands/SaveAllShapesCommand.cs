using System.Collections.Generic;

namespace Figure_Calculator.Commands
{
    class SaveAllShapesCommand : ICommand
    {
        public SaveAllShapesCommand(string name, List<Shape> shapes)
        {
            Name = name;
            Shapes = shapes;
        }
        public string Name { get; }
        public List<Shape> Shapes { get; set; }
        public void Execute(string data)
        {

        }
    }
}

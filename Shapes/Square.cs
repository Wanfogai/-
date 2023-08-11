using static System.Math;

namespace Figure_Calculator
{
    internal class Square : Shape
    {
        public override string Name { get; } = "Квадрат";
        public double Side { get; set; }
        /// <summary>
        /// Фигура : Квадрат
        /// </summary>
        /// <param name="Side">SСторона квадрата</param>
        public Square(double Side)
        {
            this.Side = Side;
        }
        /// <summary>
        /// Функция, которая выполняет вычисления площади квадратов
        /// </summary>
        /// <returns>Возвращает площадь квадрата</returns>
        public override double Area()
        {
            return Round(Pow(Side, 2), 2);
        }
        /// <summary>
        /// Функция, которая выполняет вычисления периметра квадратов
        /// </summary>
        /// <returns>Возвращает периметр квадрата</returns>
        public override double Perimeter()
        {
            return Round(Side * 4, 2);
        }
        public override string ToString()
        {
            return $"Квадрат: \n  Сторона: {Side}";
        }
        public override byte[] GetBytes()
        {
            return new byte[] { };
        }
    }
}

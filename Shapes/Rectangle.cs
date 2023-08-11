using static System.Math;

namespace Figure_Calculator
{
    class Rectangle : Shape
    {
        public override string Name { get; } = "Многоугольник";
        public double A { get; set; }
        public double B { get; set; }
        /// <summary>
        /// Фигура : Прямоугольник
        /// </summary>
        /// <param name="A">Сторона A прямоугольника</param>
        /// <param name="B">Сторона B прямоугольника</param>
        public Rectangle(double A, double B)
        {
            this.A = A;
            this.B = B;
        }
        /// <summary>
        /// Функция, которая выполняет вычисления площади прямоугольников
        /// </summary>
        /// <returns>Возвращает площадь прямоугольника</returns>
        public override double Area()
        {
            return Round(A * B, 2);
        }
        /// <summary>
        /// Функция, которая выполняет вычисления периметра прямоугольников
        /// </summary>
        /// <returns>Возвращает периметр прямоугольника</returns>
        public override double Perimeter()
        {
            return Round((A + B) * 2, 2);
        }
        public override string ToString()
        {
            return $"Прямоугольник: \n  A: {A}\n  B: {B}";
        }
        public override byte[] GetBytes()
        {
            return new byte[] { };
        }
    }
}

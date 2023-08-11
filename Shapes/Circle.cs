using System;
using static System.Math;

namespace Figure_Calculator
{
    class Circle : Shape
    {
        public override string Name { get; } = "Круг";
        public double Radius { get; set; }
        /// <summary>
        /// Фигура : Круг
        /// </summary>
        /// <param name="Radius">Радиус круга</param>
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        /// <summary>
        /// Фигура : Кург
        /// (Без параметров)
        /// </summary>
        public override double Area()
        {
            return Round(PI * Pow(Radius, 2), 2);
        }
        /// <summary>
        /// Функция, которая выполняет вычисления периметра окружностей
        /// </summary>
        /// <returns>Возвращает периметр круга</returns>
        public override double Perimeter()
        {
            return Round(2 * PI * Radius, 2);
        }
        public override string ToString()
        {
            return $"Круг: \n  Радиус: {Radius}";
        }
        public override byte[] GetBytes()
        {
            return BitConverter.GetBytes('c' + Radius + 'n'); ;
        }
    }
}

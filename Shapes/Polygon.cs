using System;
using static System.Console;
using System.Collections.Generic;

namespace Figure_Calculator.Shapes
{
    internal class Polygon : Shape
    {
        public override string Name { get; } = "Многоугольник";
        public List<Point> Points { get; set; }
        public Polygon(List<Point> Points)
        {
            this.Points = Points;
        }
        public override double Area()
        {
            double sideA = 0, sideB = 0;
            Points.Add(Points[0]);
            for (int i = 0; i < Points.Count-1; i++)
            {
               sideA += Points[i].X * Points[i+1].Y;
            }
            for (int i = 0; i < Points.Count-1; i++)
            {
                sideB += Points[i+1].X * Points[i].Y;
            }
            Points.RemoveAt(Points.Count - 1);
            return Math.Abs(sideA-sideB)/2;
        }
        public override double Perimeter()
        {
            double P = 0;
            Points.Add(Points[0]);
            for (int i = 0; i < Points.Count - 1; i++)
            {
                double side;
                side = Math.Sqrt(Math.Pow(Points[i + 1].X - Points[i].X, 2) + Math.Pow(Points[i + 1].Y - Points[i].Y, 2));
                P += side;
            }
            Points.RemoveAt(Points.Count - 1);
            return P;
        }

        public bool IsValidate()
        {
            double first, second;
            for (int i = 0; i < Points.Count-1; i++)
            {
                for (int j = i+1; j < Points.Count; j++)
                {
                    if (Points[i].X == Points[j].X && Points[i].Y == Points[j].Y)
                        return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string pos = "Многоугольник:";
            for (int i = 0; i < Points.Count; i++)
            {
                pos = pos.Insert(pos.Length, $"\n  X{i + 1}:{Points[i].X}; Y{i + 1}:{Points[i].Y}");
            }
            return pos;
        }
        public override byte[] GetBytes()
        {
            return new byte[] { };
        }
    }
}

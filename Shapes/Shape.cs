namespace Figure_Calculator
{
    abstract class Shape
    {
        abstract public string Name { get; }
        abstract public double Area();
        abstract public double Perimeter();
        abstract public byte[] GetBytes();
    }
}

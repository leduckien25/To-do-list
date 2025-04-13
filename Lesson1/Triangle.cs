using System.Formats.Asn1;

class Triangle : IShape
{
    private double a, b, c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double area()
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public double perimeter()
    {
        return a + b + c;
    }

    public string toString()
    {
        return (a + " " + b + " " + c).ToString();
    }
}
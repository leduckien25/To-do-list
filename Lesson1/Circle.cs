class Circle : IShape
{
    private double r;

    public Circle(double r)
    {
        this.r = r;
    }

    public double area()
    {
        return Math.PI * r * r;
    }

    public string toString()
    {
        return r.ToString();
    }

    public double perimeter()
    {
        return Math.PI * 2 * r;
    }
}
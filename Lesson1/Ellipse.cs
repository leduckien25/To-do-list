class Ellipse : IShape
{
    private double r1, r2;

    public Ellipse(double r1, double r2)
    {
        this.r1 = r1;
        this.r2 = r2;
    }

    public double area()
    {
        return Math.PI * r1 * r2;
    }

    public double perimeter()
    {
        return Math.PI * (r1 + r2);
    }

    public string toString()
    {
        return (r1 + " " + r2).ToString();
    }
}
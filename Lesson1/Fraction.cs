class Fraction
{
    private int numerator, denominator;


    public Fraction() { }
    public Fraction(int num, int den)
    {
        numerator = num;
        denominator = den;
    }


    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int tmp = a;
            a = b;
            b = tmp % b;
        }
        return a;
    }

    public void simplify()
    {
        var gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    public Fraction addition(Fraction f)
    {
        var result = new Fraction();

        result.numerator = numerator * f.denominator + denominator * f.numerator;
        result.denominator = denominator * f.denominator;

        result.simplify();
        return result;
    }
    public Fraction multiplication(Fraction f)
    {
        var result = new Fraction();

        result.numerator = numerator * f.numerator;
        result.denominator = denominator * f.denominator;

        result.simplify();
        return result;
    }

    public Fraction subtraction(Fraction f)
    {
        var result = new Fraction();

        result.numerator = numerator * f.denominator - denominator * f.numerator;
        result.denominator = denominator * f.denominator;

        result.simplify();
        return result;

    }

    public Fraction division(Fraction f)
    {
        var result = new Fraction();

        result.numerator = numerator * f.denominator;
        result.denominator = denominator * f.numerator;

        result.simplify();
        return result;
    }

    public string toString()
    {
        return (numerator + "/" + denominator).ToString();
    }

}
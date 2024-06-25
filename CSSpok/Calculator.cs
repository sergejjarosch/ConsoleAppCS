namespace CSSpok;

public class Calculator
{
    public double CalcTriangleSquare(double ab, double bc, double ac)
    {
        double p = (ab + bc + ac) / 2;
        return  Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
    }

    public double CalcTriangleSquare(double b, double h)
    {
        return 0.5 * b * h;
    }
}
namespace Sqrt_Calculator;

public class Calculator
{
    public double Sqrt(double x)
    {
        if (x < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(x), "x lower than 0");
        }

        if (x >= 0)
        {
            Console.WriteLine("OK");
        }

        return Math.Sqrt(x);
    }
}
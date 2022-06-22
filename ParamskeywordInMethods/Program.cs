using System;

class Program
{
    static double Findproduct(params double[] values)
    {
        double product = 1;

        foreach(var d in values)
        {
            product *= d;
        }
        return product;
    }
    static void Main()
    {
        Console.WriteLine("1*2={0} ", Findproduct(1, 2));
        Console.WriteLine("2*2*3={0} ",Findproduct(2,2, 3));

    }
}
using System;
using System.Globalization;
class AreaCirculo
{

    static void Main(string[] args)
    {
        double n, r, r2, area;

        n = 3.14159;
        r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        r2 = Math.Pow(r, 2);

        area = n * r2;

        Console.WriteLine("A=" + area.ToString("F4"), CultureInfo.InvariantCulture);        
    }
}
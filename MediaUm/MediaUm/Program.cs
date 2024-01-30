using System;
using System.Globalization;

class MediaUm
{
    static void Main(string[] args)
    {
        //double A, B, MEDIA;

        //A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //MEDIA = ((A * 3.5) + (B * 7.5)) / 11.0;

        //Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"), CultureInfo.InvariantCulture);

        //double A, B, C, MEDIA;

        //A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //MEDIA = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10.0;

        //Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"), CultureInfo.InvariantCulture);

        //int A, B, C, D, DIFERENCA;

        //A = int.Parse(Console.ReadLine());
        //B = int.Parse(Console.ReadLine());
        //C = int.Parse(Console.ReadLine());
        //D = int.Parse(Console.ReadLine());
        //DIFERENCA = ((A * B) - (C * D));

        //Console.WriteLine("DIFERENCA = " + DIFERENCA);

        //int Number, HorasTrabalhadas;
        //double Salario, ValorHora;

        //Number = int.Parse(Console.ReadLine());
        //HorasTrabalhadas = int.Parse(Console.ReadLine());
        //ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //Salario = (double) HorasTrabalhadas * ValorHora;

        //Console.WriteLine("NUMBER = " + Number);
        //Console.WriteLine("SALARY = " + "U$ " + Salario.ToString("F2"), CultureInfo.InvariantCulture);

        int CodP1, CodP2, NumP1, NumP2;
        double ValorUnitP1, ValorUnitP2,ValorPagar;
        string[] v = Console.ReadLine().Split(' ');
        CodP1 = int.Parse(v[0]);
        NumP1 = int.Parse(v[1]);
        ValorUnitP1 = double.Parse(v[2], CultureInfo.InvariantCulture);

        v = Console.ReadLine().Split(' ');
        CodP2 = int.Parse(v[0]);
        NumP2 = int.Parse(v[1]);
        ValorUnitP2 = double.Parse(v[2], CultureInfo.InvariantCulture);

        ValorPagar = NumP1 * ValorUnitP1 + NumP2 * ValorUnitP2;

        Console.WriteLine("VALOR A PAGAR: " + "R$ " +  ValorPagar.ToString("F2"), CultureInfo.InvariantCulture);
    }
}
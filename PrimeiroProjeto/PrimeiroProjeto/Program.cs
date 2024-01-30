using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //double x = 10.35784;

            //Console.WriteLine(x);

            //Console.WriteLine(x.ToString("F2"));

            //Console.WriteLine(x.ToString("F4"));

            //Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine("Resultado = " + x.ToString("F2"));

            //Console.WriteLine("O valor do troco é " + x + " reais");

            //Console.WriteLine("O valor do troco é " + x.ToString("F2") + "reais");



            //Casting c#
            //int x, y;

            //x = 5;

            //y = 2 * x;

            //Console.WriteLine(x);

            //Console.WriteLine(y);

            //Calculo de area do Trapezio

            //double b, B, h, area;

            //// Para valores double utilizar . depois do número inteiro | Para valores float utilizar a letra f ex: 2f

            //b = 6.0;
            //B = 8.0;
            //h = 5.0;

            //area = (b + B) / 2.0 * h;

            //Console.WriteLine("A área do trapezio é " + area.ToString() + " metros");

            ////Casting é a conversão explicita de um tipo para outro. É necessário quando o compilador não é capaz de "adivinhar" que o resultado de uma expressão deve ser de outro tipo;

            //int a, b;
            //double resultado;

            //a = 5;
            //b = 2;

            //resultado = (double) a / b;

            //Console.WriteLine(resultado);

            double a;

            int b;

            a = 5.0;
            b = (int) a;

            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}

using CotacaoDolar;
using System.Globalization;

Console.Write("Qual a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantos dólares você vai comprar? ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

Console.WriteLine("Valor a ser Pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

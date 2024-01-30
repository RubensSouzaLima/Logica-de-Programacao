using System.Globalization;

string nome;
double SalarioFixo, SalarioTotal, TotalVenda;

nome = Console.ReadLine();
SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
TotalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

SalarioTotal = TotalVenda * 15.0 / 100 + SalarioFixo;
Console.WriteLine("TOTAL = R$ " + SalarioTotal.ToString("F2", CultureInfo.InvariantCulture));

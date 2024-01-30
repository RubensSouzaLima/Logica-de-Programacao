using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos:");
Console.WriteLine("{0}, cujo preço é ${1:F2}", produto1, preco1);
Console.WriteLine("{0}, cujo preço é ${1:F2}", produto2, preco2);

Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");

Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F3"));
Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F3", CultureInfo.InvariantCulture));
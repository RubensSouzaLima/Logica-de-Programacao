using System.Globalization;

string nome = Console.ReadLine();
int quartos = int.Parse(Console.ReadLine());
double precoProduto = double.Parse(Console.ReadLine());

string[] vet = Console.ReadLine().Split(' ');
string ultimoNome = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2]);

Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
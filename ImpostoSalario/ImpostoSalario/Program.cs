using ImpostoSalario;
using System;
using System.Globalization;

Funcionario fun = new Funcionario();

Console.Write("Nome: ");
fun.Nome = Console.ReadLine();
Console.Write("Salário Bruto: ");
fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine("Funcionário: " + fun);
Console.WriteLine();
Console.Write("Deseja aumentar o salário em qual porcentagem? ");
double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
fun.AumentarSalario(porcent);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + fun);
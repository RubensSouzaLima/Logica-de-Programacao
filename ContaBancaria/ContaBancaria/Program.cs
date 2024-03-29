﻿using Conta;
using System.Globalization;

ContaBancaria conta;

Console.Write("Entre com o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial: (s/n) ");
char resp = char.Parse(Console.ReadLine());
if(resp == 's' || resp == 'S')
{
    Console.WriteLine("Entre com o valor do depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, depositoInicial);
}
else
{
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da Conta");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre com um valor para o depósito: ");
double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(deposito);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre com um valor para saque: ");
deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(deposito);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);
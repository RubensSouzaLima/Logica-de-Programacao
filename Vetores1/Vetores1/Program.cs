﻿using System.Globalization;

int N;
double[] vet;

N = int.Parse(Console.ReadLine());
vet = new double[N];

for (int i = 0; i < N; i++)
{
    vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

for (int i = 0;i < N; i++)
{
    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
}

Console.ReadLine();
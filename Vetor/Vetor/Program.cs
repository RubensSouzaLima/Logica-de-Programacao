﻿using System.Globalization;
using Vetor;

int n = int.Parse(Console.ReadLine());

//double[] vect  = new double[n];

//for (int i = 0; i < n; i++)
//{
//    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//}

//double sum = 0;
//for (int i = 0;i < n; i++)
//{
//    sum += vect[i];
//}

//double avg = sum / n;

//Console.WriteLine("Average Height = " + avg.ToString("F2", CultureInfo.InvariantCulture));

Product[] vect = new Product[n];

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vect[i] = new Product { Name = name, Price = price };
}

double sum = 0.0;
for (int i = 0;i < n; i++)
{
    sum += vect[i].Price;
}

double avg = sum / n;

Console.WriteLine("Average Price = " +  avg.ToString("F2", CultureInfo.InvariantCulture));
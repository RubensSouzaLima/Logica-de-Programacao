﻿int x, y, min ,max, soma;

x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());

if (x < 0)
{
    min = x;
    max = y;
}
else
{
    min = y;
    max = x;
}

soma = 0;
for (int i=min+1; i<max; i++)
{
    if (i % 2 != 0)
    {
        soma = soma + i;
    }
}

Console.WriteLine(soma);

Console.ReadLine();
﻿
int x = int.Parse(Console.ReadLine());
string dia;

switch (x)
{
    case 1:
        dia = "domingo";
        break;
    case 2:
        dia = "segunda";
        break;
    case 3:
        dia = "terça";
        break;
    case 4:
        dia = "quarta";
        break;
    case 5:
        dia = "quinta";
        break;
    case 6:
        dia = "sexta";
        break;
    case 7:
        dia = "sábado";
        break;
    default:
        dia = "valor inválido";
        break;
}

Console.Write("Dia da semana: " + dia);
Console.WriteLine();
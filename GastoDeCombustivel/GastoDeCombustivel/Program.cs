using System.Globalization;

int tempo, distancia, velocidade;
double litros;

tempo = int.Parse(Console.ReadLine());
velocidade = int.Parse(Console.ReadLine());

distancia = tempo * velocidade;
litros = distancia / 12.0;

Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
using System.Globalization;

double raio, volume;
raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
volume = 4.0 / 3.0 * 3.14159 * Math.Pow(raio, 3.0);

Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
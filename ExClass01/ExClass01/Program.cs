using ExClass01;
using System.Globalization;

Retangulo retangulo = new Retangulo();

Console.WriteLine("Entre com a largura e a altura do retangulo: ");
retangulo.Altura = double.Parse(Console.ReadLine());
retangulo.Largura = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("AREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
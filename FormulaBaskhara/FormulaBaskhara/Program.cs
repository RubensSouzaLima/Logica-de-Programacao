using System.Globalization;

//double a, b, c, delta, r1, r2;

//String[] vet = Console.ReadLine().Split(' ');

//a = double.Parse(vet[0], CultureInfo.InvariantCulture);
//b = double.Parse(vet[1], CultureInfo.InvariantCulture);
//c = double.Parse(vet[2], CultureInfo.InvariantCulture);

//delta = Math.Pow(b, 2.0) - 4 * a * c;

//if (a == 0 || delta < 10.0)
//{
//    Console.WriteLine("Impossivel calcular");
//}
//else
//{
//    r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
//    r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
//    Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
//    Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
//}


int x, y, z;

String[] vet = Console.ReadLine().Split(' ');

x = int.Parse(vet[0]);
y = int.Parse(vet[1]);
z = int.Parse(vet[2]);

if (x < y && x < z)
{
    Console.WriteLine("MENOR = " + x);
}
else if (y < z)
{
    Console.WriteLine("MENOR = " + y);
}
else
{
    Console.WriteLine("MENOR = " + z);
}

Console.ReadLine();
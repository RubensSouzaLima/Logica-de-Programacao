using System.Globalization;

//double b, a, area, perimetro, diagonal;
//b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//area = b * a;
//perimetro = 2 * b + 2 * a ;
//diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

//Console.WriteLine("AREA = " + area.ToString("F4"), CultureInfo.InvariantCulture);
//Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"), CultureInfo.InvariantCulture);
//Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"), CultureInfo.InvariantCulture);

string nome1, nome2;
int idade1, idade2;
double media;
string[] vet;

vet = Console.ReadLine().Split(' ');
nome1 = vet[0];
idade1 = int.Parse(vet[1]);
vet = Console.ReadLine().Split(' ');
nome2 = vet[0];
idade2 = int.Parse(vet[1]);

media = (double) (idade1 + idade2) / 2;

Console.WriteLine("A idade média " + nome1 + " e " + nome2 + " é de " 
    + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");
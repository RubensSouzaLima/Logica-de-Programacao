int N, X, SOMA;

N = int.Parse(Console.ReadLine());

SOMA = 0;

for (int i = 1; i <= N; i++)
{
    X = int.Parse(Console.ReadLine());
    SOMA = SOMA + X;
}
Console.WriteLine(SOMA);
Console.ReadLine();
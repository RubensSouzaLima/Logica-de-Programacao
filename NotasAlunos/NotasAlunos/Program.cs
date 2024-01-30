
using NotasAlunos;
using System.Globalization;

Aluno aluno = new Aluno();

Console.Write("Nome do Aluno: ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do Aluno");
aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Nota Final = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

if (aluno.Aprovado())
{
    Console.WriteLine("Aprovado");
}
else 
{
    Console.WriteLine("Reprovado");
    Console.WriteLine("Faltaram " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
}
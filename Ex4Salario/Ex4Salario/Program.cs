int numeroFuncionario = int.Parse(Console.ReadLine());
int numeroHorasTrabalhadas = int.Parse(Console.ReadLine());
double valorHora = double.Parse(Console.ReadLine());
double salario = valorHora * numeroHorasTrabalhadas;
Console.WriteLine("Number = " + numeroFuncionario);
Console.WriteLine("SALARIO = " + salario.ToString("F2"));
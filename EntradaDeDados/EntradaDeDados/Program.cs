using System;
using System.Globalization;

namespace EntradaDeDados
{   
    class Program
    {
        static void Main(string[] args) {

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();
            //string s = Console.ReadLine();
            //string[] v = Console.ReadLine().Split(' ');
            //string a = v[0];
            //string b = v[1];
            //string c = v[2];

            //Console.WriteLine("Você digitou: ");
            ////Console.WriteLine(frase);
            ////Console.WriteLine(x);
            ////Console.WriteLine(y); 
            ////Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //int n1  = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string[] v = Console.ReadLine().Split(' ');
            //string nome = v[0];
            //char sexo = char.Parse(v[1]);
            //int idade = int.Parse(v[2]);
            //double tamanho = double.Parse(v[3], CultureInfo.InvariantCulture);


            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(tamanho.ToString("F2"), CultureInfo.InvariantCulture);

            //Exercicio 1
            //Fazer um programa para executar a seguite interação com o usuário, lendo os valores destacados em vermelho, e depois mostrar os dados na tela:
                        
            string nomeCompleto = Console.ReadLine();
            int numeroQuartos = int.Parse(Console.ReadLine());
            double valorCasa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] v = Console.ReadLine().Split(' ');
            string sobrenome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu nome completo: ");
            Console.WriteLine(nomeCompleto);
            Console.WriteLine("Quantos quartos tem na siua casa: ");
            Console.WriteLine(numeroQuartos);
            Console.WriteLine("Qual o valor da casa: " + "R$");
            Console.WriteLine(valorCasa.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Último Nome, Idade e Altura: ");
            Console.WriteLine(sobrenome + idade + altura.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
using Curso;
using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 900.00, 15);

            produto.Nome = "T";
            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Quantidade);

        }
    }
}

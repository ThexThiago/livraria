using System;

namespace livraria
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
           Console.WriteLine("Digite o código do Livro");
            livro.cod = Console.ReadLine();


            Console.WriteLine("Digite o nome do Livro");
            livro.nome = Console.ReadLine();

            Console.WriteLine("Digite o valor do Livro");
            livro.valor = Double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Código do Livro  " + livro.cod);
            Console.WriteLine("nome do Livro  "+ livro.nome);
            Console.WriteLine($"valor do Livro  {livro.valor.ToString("C")}"); 












        }
    }
}

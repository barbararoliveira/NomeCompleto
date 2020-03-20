using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o seu primeiro nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Escreva o seu sobrenome:");
            string sobrenome = Console.ReadLine();
            Console.Write("Seu nome completo: " );
            Console.WriteLine(nome + " " + sobrenome);
            Console.Write("Nome de catálogo: ");
            Console.WriteLine(sobrenome + ", " + nome);

        }
    }
}
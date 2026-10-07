using System;

class Program
{
    static void Main()
    {
        // ExercÃ­cio 16:
        // O professor deverÃ¡ fornecer um cÃ³digo propositalmente
        // alterado com erros para ser corrigido pelo aluno.

        string nome;
        int idade;

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("       PROGRAMA CORRIGIDO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine("========================================");
    }
}

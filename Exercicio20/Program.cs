using System;

class Program
{
    static void Main()
    {
        // DESAFIO FINAL - PRIMEIRO ALUNO

        string nome;
        int idade;
        string cidade;
        double altura;
        string curso;
        bool ativo;

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Altura: ");
        altura = double.Parse(Console.ReadLine());

        Console.Write("Curso: ");
        curso = Console.ReadLine();

        Console.Write("Estudante ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          ALUNO CADASTRADO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Altura: {altura:F2} m");
        Console.WriteLine($"Curso: {curso}");
        Console.WriteLine($"Ativo: {ativo}");
        Console.WriteLine("========================================");

        Console.WriteLine();
        Console.WriteLine("ANÃLISE:");
        Console.WriteLine("Para vÃ¡rios alunos, muitas variÃ¡veis seriam necessÃ¡rias.");
        Console.WriteLine("Uma estrutura Aluno poderia agrupar essas informaÃ§Ãµes.");
    }
}

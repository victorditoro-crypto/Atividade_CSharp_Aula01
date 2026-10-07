using System;

class Program
{
    static void Main()
    {
        // Sistema profissional de cadastro de alunos

        string nome;
        int idade;
        string cidade;
        string curso;
        int matricula;
        double altura;
        string telefone;
        string turno;
        bool ativo;

        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());
        Console.Write("Cidade: ");
        cidade = Console.ReadLine();
        Console.Write("Curso: ");
        curso = Console.ReadLine();
        Console.Write("MatrÃ­cula: ");
        matricula = int.Parse(Console.ReadLine());
        Console.Write("Altura: ");
        altura = double.Parse(Console.ReadLine());
        Console.Write("Telefone: ");
        telefone = Console.ReadLine();
        Console.Write("Turno: ");
        turno = Console.ReadLine();
        Console.Write("Aluno ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("       SISTEMA DE CADASTRO DE ALUNOS");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Curso: {curso}");
        Console.WriteLine($"MatrÃ­cula: {matricula}");
        Console.WriteLine($"Altura: {altura:F2} m");
        Console.WriteLine($"Telefone: {telefone}");
        Console.WriteLine($"Turno: {turno}");
        Console.WriteLine($"Ativo: {ativo}");
        Console.WriteLine("========================================");
    }
}

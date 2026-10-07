using System;

class Program
{
    static void Main()
    {
        string nome;
        int idade;
        string curso;
        string cidade;
        int matricula;
        string turno;
        bool ativo;

        Console.Write("Nome do aluno: ");
        nome = Console.ReadLine();
        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());
        Console.Write("Curso: ");
        curso = Console.ReadLine();
        Console.Write("Cidade: ");
        cidade = Console.ReadLine();
        Console.Write("NÃºmero da matrÃ­cula: ");
        matricula = int.Parse(Console.ReadLine());
        Console.Write("Turno: ");
        turno = Console.ReadLine();
        Console.Write("Ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("              MATRÃCULA");
        Console.WriteLine("========================================");
        Console.WriteLine($"Aluno: {nome}");
        Console.WriteLine($"MatrÃ­cula: {matricula}");
        Console.WriteLine($"Curso: {curso}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Turno: {turno}");
        Console.WriteLine($"Ativo: {ativo}");
        Console.WriteLine("========================================");
        Console.WriteLine("MATRÃCULA REGISTRADA COM SUCESSO");
        Console.WriteLine("========================================");
    }
}

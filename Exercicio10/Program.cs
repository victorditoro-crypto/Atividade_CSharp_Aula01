using System;

class Program
{
    static void Main()
    {
        string nome;
        int idade;
        string cidade;
        string telefone;
        string curso;
        bool trabalha;

        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());
        Console.Write("Cidade: ");
        cidade = Console.ReadLine();
        Console.Write("Telefone: ");
        telefone = Console.ReadLine();
        Console.Write("Curso: ");
        curso = Console.ReadLine();
        Console.Write("Trabalha? (true/false): ");
        trabalha = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("        INSCRIÃ‡ÃƒO REALIZADA");
        Console.WriteLine("========================================");
        Console.WriteLine("DADOS DO CANDIDATO");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Telefone: {telefone}");
        Console.WriteLine($"Curso: {curso}");
        Console.WriteLine($"Trabalha: {trabalha}");
        Console.WriteLine("========================================");
    }
}

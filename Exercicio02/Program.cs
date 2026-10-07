using System;

class Program
{
    static void Main()
    {
        string nome;
        int idade;
        string cidade;
        string cargo;
        double salario;
        char inicial;
        bool ativo;

        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());
        Console.Write("Cidade: ");
        cidade = Console.ReadLine();
        Console.Write("Cargo: ");
        cargo = Console.ReadLine();
        Console.Write("SalÃ¡rio: ");
        salario = double.Parse(Console.ReadLine());
        Console.Write("Inicial: ");
        inicial = char.Parse(Console.ReadLine());
        Console.Write("EstÃ¡ ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("       FICHA PROFISSIONAL");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"SalÃ¡rio: R$ {salario:F2}");
        Console.WriteLine($"Inicial: {inicial}");
        Console.WriteLine($"Ativo: {ativo}");
        Console.WriteLine("========================================");
    }
}

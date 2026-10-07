using System;

class Program
{
    static void Main()
    {
        // DeclaraÃ§Ã£o das variÃ¡veis
        string nome;
        int idade;
        string cidade;
        double altura;

        // Entrada dos dados
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Altura: ");
        altura = double.Parse(Console.ReadLine());

        // SaÃ­da organizada
        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          DADOS PESSOAIS");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Altura: {altura:F2} m");
        Console.WriteLine("========================================");
    }
}

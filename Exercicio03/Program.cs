using System;

class Program
{
    static void Main()
    {
        string nome;
        int codigo;
        string categoria;
        double preco;
        int quantidade;
        char inicialCategoria;
        bool disponivel;

        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("CÃ³digo: ");
        codigo = int.Parse(Console.ReadLine());
        Console.Write("Categoria: ");
        categoria = Console.ReadLine();
        Console.Write("PreÃ§o: ");
        preco = double.Parse(Console.ReadLine());
        Console.Write("Quantidade: ");
        quantidade = int.Parse(Console.ReadLine());
        Console.Write("Inicial da categoria: ");
        inicialCategoria = char.Parse(Console.ReadLine());
        Console.Write("DisponÃ­vel? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          PRODUTO CADASTRADO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"CÃ³digo: {codigo}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"PreÃ§o: R$ {preco:F2}");
        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine($"Inicial: {inicialCategoria}");
        Console.WriteLine($"DisponÃ­vel: {disponivel}");
        Console.WriteLine("========================================");
    }
}

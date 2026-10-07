using System;

class Program
{
    static void Main()
    {
        string marca;
        string modelo;
        int ano;
        double preco;
        string categoria;
        char inicialMarca;
        bool disponivel;

        Console.Write("Marca: ");
        marca = Console.ReadLine();
        Console.Write("Modelo: ");
        modelo = Console.ReadLine();
        Console.Write("Ano: ");
        ano = int.Parse(Console.ReadLine());
        Console.Write("PreÃ§o: ");
        preco = double.Parse(Console.ReadLine());
        Console.Write("Categoria: ");
        categoria = Console.ReadLine();
        Console.Write("Inicial da marca: ");
        inicialMarca = char.Parse(Console.ReadLine());
        Console.Write("DisponÃ­vel? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          VEÃCULO CADASTRADO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"PreÃ§o: R$ {preco:F2}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"Inicial: {inicialMarca}");
        Console.WriteLine($"DisponÃ­vel: {disponivel}");
        Console.WriteLine("========================================");
    }
}

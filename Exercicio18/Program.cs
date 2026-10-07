using System;

class Program
{
    static void Main()
    {
        string placa;
        string modelo;
        string cor;
        int horaEntrada;
        double valor;
        bool pago;

        Console.Write("Placa: ");
        placa = Console.ReadLine();
        Console.Write("Modelo: ");
        modelo = Console.ReadLine();
        Console.Write("Cor: ");
        cor = Console.ReadLine();
        Console.Write("Hora de entrada: ");
        horaEntrada = int.Parse(Console.ReadLine());
        Console.Write("Valor: ");
        valor = double.Parse(Console.ReadLine());
        Console.Write("Pagamento realizado? (true/false): ");
        pago = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          ESTACIONAMENTO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Placa: {placa}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Cor: {cor}");
        Console.WriteLine($"Hora de entrada: {horaEntrada}h");
        Console.WriteLine($"Valor: R$ {valor:F2}");
        Console.WriteLine($"Pago: {pago}");
        Console.WriteLine("========================================");
    }
}

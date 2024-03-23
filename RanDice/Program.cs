using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Por favor, forneça o número de dados e a semente.");
            return;
        }

        if (!int.TryParse(args[0], out int numberOfDice) || !int.TryParse(args[1], out int seed))
        {
            Console.WriteLine("Entrada inválida para o número de dados ou semente.");
            return;
        }

        Random random = new Random(seed);
        int sum = 0;

        for (int i = 0; i < numberOfDice; i++)
        {
            sum += random.Next(1, 7); // valores entre 1 e 6
        }

        Console.WriteLine(sum);
    }
}


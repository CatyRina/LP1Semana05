using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1 || !int.TryParse(args[0], out int numberOfEnemies) || numberOfEnemies <= 0)
            {
                Console.WriteLine("Por favor, forneça um número válido de inimigos como argumento da linha de comandos.");
                return;
            }

            Enemy[] enemies = new Enemy[numberOfEnemies];

            for (int i = 0; i < numberOfEnemies; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string name = Console.ReadLine();
                enemies[i] = new Enemy(name);
            }

            Console.WriteLine("Nome   Health   Shield");

            foreach (var enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName(),-8} {enemy.GetHealth(),-8} {enemy.GetShield(),-8}");
                
            }
        }
    }
}


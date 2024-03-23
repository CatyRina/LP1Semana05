using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        var crono1 = new System.Diagnostics.Stopwatch();
        var crono2 = new System.Diagnostics.Stopwatch();

        // Inicia contagem do tempo em crono1
        crono1.Start();

        // Pausa o programa durante 0.6 segundos
        Thread.Sleep(600);

        // Inicia contagem do tempo em crono2
        crono2.Start();

        // Programa durante mais 0.2 segundos
        Thread.Sleep(200);

        // Contagem do tempo nos dois cronômetros
        crono1.Stop();
        crono2.Stop();

        // Mostra no ecrã o tempo decorrido em cada cronômetro, em segundos, com três casas decimais
        Console.WriteLine($"Tempo decorrido em crono1: {crono1.Elapsed.TotalSeconds:F3} segundos");
        Console.WriteLine($"Tempo decorrido em crono2: {crono2.Elapsed.TotalSeconds:F3} segundos");
    }
}

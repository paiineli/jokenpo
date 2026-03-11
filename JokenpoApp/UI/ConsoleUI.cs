using JokenpoApp.Enums;
using JokenpoApp.Models;
using JokenpoApp.Services;

namespace JokenpoApp.UI
{
    public class ConsoleUI
    {
        private readonly JokenpoService _service = new JokenpoService();

        public void Iniciar()
        {
            Console.WriteLine("=== JOKENPÔ ===");

            while (true)
            {
                Console.WriteLine("\nEscolha sua jogada:");
                Console.WriteLine("0 - Pedra");
                Console.WriteLine("1 - Papel");
                Console.WriteLine("2 - Tesoura");
                Console.WriteLine("3 - Sair");
                Console.Write("Opção: ");

                string input = Console.ReadLine() ?? "";

                if (input == "3") break;

                if (!int.TryParse(input, out int opcao) || opcao < 0 || opcao > 2)
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }

                Jogada jogadaJogador = (Jogada)opcao;
                Partida partida = _service.Resultado(jogadaJogador);

                Console.WriteLine($"\nVocê jogou: {partida.JogadaJogador}");
                Console.WriteLine($"Computador jogou: {partida.JogadaComputador}");
                Console.WriteLine($"Resultado: {partida.Resultado}");
            }

            Console.WriteLine("\nObrigado por jogar!");
        }
    }
}
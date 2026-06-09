using JokenpoApp.Enums;
using JokenpoApp.Models;
using JokenpoApp.Services;

namespace JokenpoApp.UI
{
    public class ConsoleUI
    {
        private readonly JokenpoService _service = new JokenpoService();

        public void Start()
        {
            Console.WriteLine("=== JOKENPO ===");

            while (true)
            {
                Console.WriteLine("\nChoose your move:");
                Console.WriteLine("0 - Rock");
                Console.WriteLine("1 - Paper");
                Console.WriteLine("2 - Scissors");
                Console.WriteLine("3 - Quit");
                Console.Write("Option: ");

                string input = Console.ReadLine() ?? "";

                if (input == "3") break;

                if (!int.TryParse(input, out int option) || option < 0 || option > 2)
                {
                    Console.WriteLine("Invalid option!");
                    continue;
                }

                Move playerMove = (Move)option;
                Match match = _service.Play(playerMove);

                Console.WriteLine($"\nYou played: {match.PlayerMove}");
                Console.WriteLine($"Computer played: {match.ComputerMove}");
                Console.WriteLine($"Result: {match.Result}");
            }

            Console.WriteLine("\nThanks for playing!");
        }
    }
}

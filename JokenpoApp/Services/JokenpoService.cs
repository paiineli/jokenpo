using JokenpoApp.Enums;
using JokenpoApp.Models;

namespace JokenpoApp.Services
{
    public class JokenpoService
    {
        public Move GenerateComputerMove()
        {
            Random random = new Random();
            return (Move)random.Next(0, 3);
        }

        public Match Play(Move playerMove)
        {
            Match match = new Match();

            match.PlayerMove = playerMove;
            match.ComputerMove = GenerateComputerMove();

            if (match.PlayerMove == match.ComputerMove)
                match.Result = "Draw!";

            else if ((match.PlayerMove == Move.Rock && match.ComputerMove == Move.Scissors) ||
                     (match.PlayerMove == Move.Paper && match.ComputerMove == Move.Rock) ||
                     (match.PlayerMove == Move.Scissors && match.ComputerMove == Move.Paper))
                match.Result = "You won!";
            else
                match.Result = "Computer won!";

            return match;
        }
    }
}

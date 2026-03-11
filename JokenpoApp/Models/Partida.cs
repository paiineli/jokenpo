using JokenpoApp.Enums;

namespace JokenpoApp.Models
{
    public class Partida
    {
        public string Jogador { get; set; } = string.Empty;

        public string Computador { get; set; } = string.Empty;

        public string Resultado { get; set; } = string.Empty;

        public Jogada JogadaJogador { get; set; }

        public Jogada JogadaComputador { get; set; }
    }
}

using JokenpoApp.Enums;
using JokenpoApp.Models;

namespace JokenpoApp.Services
{
    public class JokenpoService
    {
        public Jogada RealizarJogada()
        {
            Random random = new Random();
            return (Jogada)random.Next(0, 3);
        }

        public Partida Resultado(Jogada jogadaJogador)
        {
            Partida partida = new Partida();

            partida.JogadaJogador = jogadaJogador;
            partida.JogadaComputador = RealizarJogada();

            if (partida.JogadaJogador == partida.JogadaComputador)
                partida.Resultado = "Empate!";

            else if ((partida.JogadaJogador == Jogada.Pedra && partida.JogadaComputador == Jogada.Tesoura) ||
                     (partida.JogadaJogador == Jogada.Papel && partida.JogadaComputador == Jogada.Pedra) ||
                     (partida.JogadaJogador == Jogada.Tesoura && partida.JogadaComputador == Jogada.Papel))
                partida.Resultado = "Você venceu!";
            else
                partida.Resultado = "Computador venceu!";

            return partida;
        }
    }
}

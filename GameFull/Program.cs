using System;
using GameFull.Lib;

namespace GameFull
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(
                new Jogador2("Jose de Alencar"),
                new Jogador1("Tafarel")            
            );
            jogo.IniciarJogo();
        }
    }     
}

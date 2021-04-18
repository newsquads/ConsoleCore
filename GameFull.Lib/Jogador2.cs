using GameFull.Interface;

namespace GameFull.Lib
{
    public class Jogador2 : IJogador
    {
        private readonly string _Nome;
        public Jogador2(string nome)
        {
            _Nome = nome;
        }
        public string Chuta()
        {
            return $"{_Nome} deu um bicudo na bola \n";
        }

        public string Corre()
        {
            return $"{_Nome} pernas pra quem ti quer \n ";
        }

        public string Passe()
        {
            return $"{_Nome} drible lindo";
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoDeJogos
{
    public class Jogo
    {
        public List<Jogo> listaDeJogos = new List<Jogo>();

        public Jogo(string nome, string gender)
        {
            this.Nome = nome;
            this.Gender = gender;
        }

        public string Nome { get; }
        public string Gender { get; }
        void AdicionarJogo(Jogo NovoJogo)
        {
            listaDeJogos.Add(NovoJogo);
        }
        void RemoverJogo(Jogo RemoverJogo)
        {
            listaDeJogos.Remove(RemoverJogo);
        }
        void ListaDejogos(Jogo ListaDejogos)
        {

        }
    }
}

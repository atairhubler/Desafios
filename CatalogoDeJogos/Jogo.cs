using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoDeJogos
{
    public class Jogo
    {

        public Jogo(string nome, string gender)
        {
            this.Nome = nome;
            this.Gender = gender;
        }

        public string Nome {  get; }
        public string Gender { get; }
    }
}

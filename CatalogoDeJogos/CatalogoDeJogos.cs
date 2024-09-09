namespace CatalogoDeJogos
{
    public class CatalogoDeJogosC
    {
        public class Jogo
        {
            public string nome { get; }
            public Jogo(string nome)
            {
                this.nome = nome;
            }
        }

        public void CriarNovoJogo(string novoJogo, List<Jogo> listaJogo)
        {
            var jogoNovo = new Jogo(novoJogo);
            listaJogo.Add(jogoNovo);
        }
        public void ListarJogos(List<Jogo> listaJogo)
        {
            foreach (Jogo joguinho in listaJogo)
            {
                Console.WriteLine(joguinho.nome);
            }
        }

    }
}

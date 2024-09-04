


public class Catalogo()
{
    
    public class jogo
    {
        public jogo(string Name, string Category)
        {
            name = Name;
            category = Category;

        }

        public string name { get; }
        public string category { get; }
    }
    public void AdicionarJogo(List<jogo> listaDeJogos,jogo novoJogo)
    {
        listaDeJogos.Add(novoJogo);   
    }
    public void RemoverJogo(List<jogo> listaDejogos,jogo removerJogo)
    {
        listaDejogos.Remove(removerJogo);
    }

    public void ListaJogos(List<jogo> listaJogos)
    {
        foreach (jogo jogo in listaJogos)
        {
            Console.WriteLine($"Nome:{jogo.name} Categoria: {jogo.category}");
        }
    }


}











/*
 
Desenvolver uma classe que representa um catálogo de jogos, 
com uma lista de Jogos
e métodos para manipular essa lista, 
bem como um construtor que faça sua inicialização.


Classes:

Jogo
    Contrutor

Catalogo
    Metodo adicionar jogo
    Metodo remover jogo
    Metodo mostrar lista de jogos

*/
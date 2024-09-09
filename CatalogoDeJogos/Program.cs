

using CatalogoDeJogos;
using static CatalogoDeJogos.CatalogoDeJogosC;


class Program
{
    static void Main(string[] args)
    {

        var catalogo1 = new CatalogoDeJogosC();

        List<Jogo> primeiraLista = new List<Jogo>
        {
            new Jogo ("Mario"),
            new Jogo ("Pubg"),
            new Jogo ("DeadLock")

        };

        catalogo1.ListarJogos(primeiraLista);

        //catalogo1.CriarNovoJogo("Mario", primeiraLista);
        //catalogo1.CriarNovoJogo("Pubg", primeiraLista);
        //catalogo1.CriarNovoJogo("DeadLock", primeiraLista);



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
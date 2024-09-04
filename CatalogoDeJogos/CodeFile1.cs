using System.Reflection.Metadata;
using static Catalogo;



var primeiroCatalogo = new Catalogo();

List<jogo> jogoList = new List<jogo>();


var jogo1 = new Catalogo.jogo("Mario","Aventura");
var jogo2 = new Catalogo.jogo("DeadLock","FPS");

primeiroCatalogo.AdicionarJogo(jogoList,jogo1);
primeiroCatalogo.AdicionarJogo(jogoList, jogo2);

primeiroCatalogo.ListaJogos(jogoList);


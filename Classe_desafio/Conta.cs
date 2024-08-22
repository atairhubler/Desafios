

class Titular
{
    public string nomeTitular { get; set; }
}
class Conta
{
    public Titular titular { get; set; }
    public int agencia { get; set; }
    public long conta { get; set; }
    public double saldo { get; set; }
    public double limite { get; set; }

    public string DetalhesConta() => $"Titular: {titular.nomeTitular}\nAgência: {agencia}\nConta: {conta}\nSaldo: {saldo}\nLimite: {limite} ";
}




//Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.

//Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.
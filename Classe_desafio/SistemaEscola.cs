


using System;

class Menu
{
    private Aluno aluno = new Aluno();
    public void MenuDeOp()
    {
        Console.WriteLine("Digite 1 para cadastrar");
        Console.WriteLine("Digite 2 para consultar a lista de cadastrados");
        string numeroL = Console.ReadLine()!;
        int numero = int.Parse(numeroL);


        switch (numero)
        {
            case 1:
                aluno.CadastrarAlunos();
                break;

            case 2:
                aluno.ConsultarAlunosCadastrados();
                break;
        }



    }
}

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }


    private static List<Aluno> alunos = new List<Aluno>();

    public void CadastrarAlunos()
    {

        Console.WriteLine("Digite o nome do aluno que quer cadastrar");
        string nomeAluno = Console.ReadLine()!;
        Console.WriteLine($"Digite a idade de {nomeAluno}");
        string idadeAlunoT = Console.ReadLine()!;
        int idadeAluno = int.Parse(idadeAlunoT);

        Aluno novoAluno = new Aluno
        {
            Nome = nomeAluno,
            Idade = idadeAluno,
        };
        alunos.Add(novoAluno);

    }

    public void ConsultarAlunosCadastrados()
    {
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Nome: {aluno}");
            Console.WriteLine($"Idade: {aluno.Idade}");
        }
    }

    
}

class NotaDisciplina
{

    public string Disciplina { get; set; }
    public double Nota { get; set; }

    public NotaDisciplina(string disciplina, double nota)
    {
        Disciplina = disciplina;
        Nota = nota;
    }
}

class Professor
{
    public string nome { get; set; }
    public string disciplina { get; set; }
}

class Disciplica
{
    public string nome { get; set; }
    public string alunosMatriculados { get; set; }
}





//Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.







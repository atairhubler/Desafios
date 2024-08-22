
class MoldeCarro
{

    public string Modelo {  get; set; }
    public string Fabricante { get; set; }
    private int ano;
    public int Ano { get => ano;
        set
        {
            if (value >= 1960 && value <= 2023)
            {
                ano = value;
            }

            else { Console.WriteLine("Valor precisa ser entre 1960 e 2023"); }
        }
    }
    public double Estoque { get; set; }

    public string DescricaoDeatalhada 
    {
        get
        {
            return ($"Fabricante {Fabricante}, Modelo {Modelo}, Ano {Ano}");
        }
    }


}

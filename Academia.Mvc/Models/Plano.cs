namespace Academia;

public class Plano
{
    public int Id {get; set;}

    public string Nome {get; set;} = string.Empty;  //string empty quer dizer nome vazio 

    public decimal ValorMensal {get; set;} //mensalidade do plano

    public int DuracaoMeses {get; set; } //duração do plano em meses

    public List<Matricula>? Matriculas {get; set;}  //lista de matriculas associadas ao plano
}
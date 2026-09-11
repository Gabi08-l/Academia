using System.Data;

namespace Academia;

public class Matricula
{
    public int Id {get; set;}

     public DateTime DataInicio {get; set;} 

     public int AlunoId {get; set;}
     public Aluno? Aluno {get; set;} //ref ai aluno associado a matricula 

    public int PlanoId {get; set;}
     public Plano? Plano {get; set;} //Ref ao plano associado a matricula
}

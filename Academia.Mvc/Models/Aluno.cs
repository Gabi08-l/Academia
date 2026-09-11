using System.Runtime.InteropServices;

namespace Academia;

public class Aluno
{
    public int Id {get; set;}

    public string Nome {get; set;} = string.Empty; //nome do aluno vazio

    public DateTime DataNascimento {get; set;} 

    public string? UserId {get; set;} // id do usuario associado ao aluno 

    public List <Matricula>? Matriculas {get; set;}

    public List <AvaliacaoFisica>? Avaliacoes {get; set;} //lista de avaliações fisicas ass ao aluno
    public List <Inscricao>?Inscricoes {get; set;} //Lista de inscrições associados ao aluno

}

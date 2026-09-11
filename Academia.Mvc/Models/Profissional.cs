namespace Academia;

public class Profissional
{
    public int Id {get; set;}

    public string Nome {get; set;} = string.Empty;  //nome do profissa = vazio

    public string Especialidade {get; set;} = string.Empty; // especialidade do profissa (musculação, pilates)

    public string? UserId {get; set;} //id do usuario associao ao profissional (opcional
    
    public List<Aula>? Aulas {get; set;}  //lista de aulas associadas ao profissa (opcional)
}

namespace EntityFramework.ModeloDB;

public class Aula_Curso
{
    public int IdCurso { get; set; }
    public int IdAula { get; set; }
    
    public Curso Curso { get; set; }
    public Aula  Aula { get; set; }
}
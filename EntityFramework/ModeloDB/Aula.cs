namespace EntityFramework.ModeloDB;

public class Aula
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Edificio { get; set; }
    
    public IList<Aula_Curso> AulaCursos { get; set; }
}
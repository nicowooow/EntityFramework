namespace EntityFramework.ModeloDB;

public class Profesor
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }

    // public int IdCurso { get; set; }
    public IList<Curso> Cursos { get; set; }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.ModeloDB;

public class Profesor
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }

    // public int IdCurso { get; set; }
    
    // [InverseProperty("Profesor")] // mapea a la clase profesor
    public IList<Curso> Cursos { get; set; }
}
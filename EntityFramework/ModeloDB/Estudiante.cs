namespace EntityFramework.ModeloDB;

public class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    
    // relacion de uno a uno para direccion
    public int DireccionId { get; set; }
    public Direccion Direccion { get; set; }
    
    
    // relacion de uno a muchos para curso
    public int CursoId { get; set; }
    public Curso Curso { get; set; }
    
}
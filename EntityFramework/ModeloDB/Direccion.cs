namespace EntityFramework.ModeloDB;

public class Direccion
{
    public int Id { get; set; }

    public string Calle { get; set; }
    public string Cuidad { get; set; }
    
    public int EstudianteId { get; set; }
    public Estudiante Estudiante { get; set; }
    
}
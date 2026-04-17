namespace EntityFramework.ModeloDB;

public class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    
    public int DireccionId { get; set; }
    public Direccion Direccion { get; set; }
    
    
}
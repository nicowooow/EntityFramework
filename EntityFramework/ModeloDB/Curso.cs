namespace EntityFramework.ModeloDB;

public class Curso
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    
    // relacion de uno a muchos para alumnos
    // al tener muchos alumnos un curso se pone una lista donde contenra todos los alumnos
    public IList<Estudiante> Estudiantes { get; set; }
    
    // relacion de cursos a profesor, se necesita saber el id del profesor para cada curso
    public int ProfesorId { get; set; }
    public IList<Profesor>  Profesores { get; set; }
    
}
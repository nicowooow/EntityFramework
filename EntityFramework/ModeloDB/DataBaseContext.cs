using Microsoft.EntityFrameworkCore;

namespace EntityFramework.ModeloDB;

public class DataBaseContext:DbContext // contexto para usar la DB 
{
    public DbSet<Producto> Productos { get; set; } // la clase a la que hace referencia la DB
    public DbSet<Estudiante> Estudiantes { get; set; } 
    public DbSet<Direccion> Direccions { get; set; } 
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Profesor> Profesores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // esto es otra manera de ponerle constraints en la DB 
        modelBuilder.Entity<Producto>()
            .Property(p => p.Nombre) // sacamos de su propieda la columna nombre
            //.HasColumnName("NombreProducto") // por si hay concordancia entre el modelo y la Db para darle un nombre 
            //.IsRequired() // lo ponemos como requerido
            .HasMaxLength(100) // que tenga un maximo de longitud
            ;

        modelBuilder.Entity<Estudiante>()
            .HasOne(e => e.Direccion) // el estudiante tiene una direccion
            .WithOne(e => e.Estudiante) // y dicha direccion esta relacionada con un estudiante
            .HasForeignKey<Direccion>(d=> d.EstudianteId) // la FK de Direccion tiene la FK con el Id del estudiate
            ;
        // .OnDelete(DeleteBehavior.NoAction)
        ;

        // modelBuilder.Entity<Estudiante>()
        //     .HasOne(e => e.Curso) // decimos que 
        //     .WithMany(e => e.Estudiantes)
        //     .HasForeignKey(d => d.CursoId)
        //     ;

        
        // con has key decimos que tome como PKs el id del curso y del aula
        modelBuilder.Entity<Aula_Curso>()
            .HasKey(ac => new { ac.IdAula, ac.IdCurso })
            ;

        // al ser una relacion NM tenemos que definir dos relaciones 1:N
        // tanto para la parte de curso y la parte de aula 
        modelBuilder.Entity<Aula_Curso>()
            .HasOne(a => a.Curso)
            .WithMany(a => a.AulaCursos)
            .HasForeignKey(ac => ac.IdCurso);
        
        modelBuilder.Entity<Aula_Curso>()
            .HasOne(a => a.Aula)
            .WithMany(a => a.AulaCursos)
            .HasForeignKey(ac => ac.IdAula);
        
    }

    // sobre escribimos el OnConfiguring
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        string path = AppDomain.CurrentDomain.BaseDirectory; // sacamos la ruta hasta donde se ejecuta 
        // Console.WriteLine(path);
        optionsBuilder.UseSqlite($"Data Source={Path.Combine(path,"..","..","..", "productos.db")}");    }
    // nos dice que combina la path actual y la retrocede hasta donde esta el cproj, yo lo dije que lo ponga ahi, pero se puede poner a otra ruta
    // Path.Combine(path,"..","..","..", "productos.db")
}
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.ModeloDB;

public class DataBaseContext:DbContext // contexto para usar la DB 
{
    public DbSet<Producto> Productos { get; set; } // la clase a la que hace referencia la DB
    public DbSet<Estudiante> Estudiantes { get; set; } 
    public DbSet<Direccion> Direccions { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // esto es otra manera de ponerle constraints en la DB 
        modelBuilder.Entity<Producto>()
            .Property(p => p.Nombre) // sacamos de su propieda la columna nombre
            //.HasColumnName("NombreProducto") // por si hay concordancia entre el modelo y la Db para darle un nombre 
            //.IsRequired() // lo ponemos como requerido
            .HasMaxLength(100) // que tenga un maximo de longitud
            ;
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
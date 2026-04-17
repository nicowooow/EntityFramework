using Microsoft.EntityFrameworkCore;

namespace EntityFramework.ModeloDB;

public class DataBaseContext:DbContext // contexto para usar la DB 
{
    public DbSet<Producto> Productos { get; set; } // la clase a la que hace referencia la DB
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = productos.db");
    }
}
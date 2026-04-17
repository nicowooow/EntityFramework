using Microsoft.EntityFrameworkCore;

namespace EntityFramework.ModeloDB;

public class DataBaseContext:DbContext // contexto para usar la DB 
{
    public DbSet<Producto> Productos { get; set; } // la clase a la que hace referencia la DB
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = AppDomain.CurrentDomain.BaseDirectory; // sacamos la ruta hasta donde se ejecuta 
        // Console.WriteLine(path);
        optionsBuilder.UseSqlite($"Data Source={Path.Combine(path,"..","..","..", "productos.db")}");    }
    // nos dice que combina la path actual y la retrocede hasta donde esta el cproj, yo lo dije que lo ponga ahi, pero se puede poner a otra ruta
    // Path.Combine(path,"..","..","..", "productos.db")
}
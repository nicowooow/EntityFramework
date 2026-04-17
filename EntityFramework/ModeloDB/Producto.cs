namespace EntityFramework.ModeloDB;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string Proveedor { get; set; } // al agregar esto hay que hacer otra migracion
}
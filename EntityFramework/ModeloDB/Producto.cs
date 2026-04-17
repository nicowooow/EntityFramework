using System.ComponentModel.DataAnnotations;

namespace EntityFramework.ModeloDB;

public class Producto
{
    // para poner atributos entre [] arriba de la propiedad
    // en este caso lo hacemos por el DataAnnotations
    // [Required] // para que sea atributo requerido ponemos Required
    public int Id { get; set; }
    // [MaxLength(100)] // para que sea una longitud maxima 
    // [] // para que sea atributo unico ponemos 
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    // public string Proveedor { get; set; } // al agregar esto hay que hacer otra migracion
    
    public double Cantidad { get; set; }
    
    public float PrecioTotal { get; set; }
}
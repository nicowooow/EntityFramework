using EntityFramework.ModeloDB;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework;

class Program
{
    static void Main(string[] args)
    {
        // intalsmos sqlite.core de microsoft (10.0.6)
        // instalamos core.Design para el modelado de la DB

        // construimos el proyecto con " dotnet build "
        // instalamos la herramienta de dotnet-ef con " dotnet tool install --global dotnet-ef "

        // hay que estar en la carpeta que contiene el .csproj
        //  hacemos el " dotnet ef migrations add (nombre de la migracion) " que nos dice haga las migraciones en c#
        // nos crea la carpeta migrations, que contiene lo que se ejecutara en la parte de migraciones

        // usamos este comando " dotnet ef database update " para que se haga el cambio en la DB

        var DBContext = new DataBaseContext();
        
        /*
        DBContext.Productos.Add( new Producto { Nombre = "Producto 1", Cantidad = 60 } );
        DBContext.Productos.Add( new Producto { Nombre = "Product 2", Cantidad = 20 } );
        DBContext.SaveChanges(); // esto es para guardar los cambios que se hicieron
        */
        
        
        Console.WriteLine("Hello, World!");

        var listaProductos = DBContext.Productos.Where(p => p.Cantidad > 10);

        foreach (var producto in listaProductos)
        {
            Console.WriteLine($"producto {producto.Id} - {producto.Nombre} - {producto.Cantidad} - {producto.Precio}");
        }

        
        /*
        DBContext.Estudiantes.Add(new Estudiante{Nombre = "Juan", Apellido = "lopez", DireccionId = 1, Curso = new Curso{Nombre =  "Curso1"}});
        DBContext.SaveChanges();

        */
        
        var estudiantesCurso = DBContext.Estudiantes.Include(i=> i.Curso).Where(e => e.Curso.Nombre == "Curso1");
        
        foreach (var estudiante_curso in estudiantesCurso)
        {
            Console.WriteLine($"estudiante {estudiante_curso.Id} - {estudiante_curso.Nombre} - {estudiante_curso.CursoId}");
        }
        
        var Profesor1 = new Profesor() { Nombre =  "luis" , Apellidos = "rodrigez" };
        var Profesor2 = new Profesor() { Nombre =  "maria" , Apellidos = "magdalena" };
        var Curso1 = new Curso{Nombre = "Matematicas", Profesores = [Profesor1]};
        var Curso2 = new Curso(){Nombre = "Lengua", Profesores =  [Profesor2]};

        var estudiante1 = new Estudiante { Nombre = "A", Apellido = "A", DireccionId = 0,Curso =  Curso1 };
        var estudiante2 = new Estudiante { Nombre = "B", Apellido = "B", DireccionId = 0,Curso =  Curso2 };
        var estudiante3 = new Estudiante { Nombre = "C", Apellido = "C", DireccionId = 0,Curso =  Curso2 };
        var estudiante4 = new Estudiante { Nombre = "D", Apellido = "D", DireccionId = 0,Curso =  Curso1 };
        
        DBContext.Estudiantes.Add(estudiante1);
        DBContext.Estudiantes.Add(estudiante2);
        DBContext.Estudiantes.Add(estudiante3);
        DBContext.Estudiantes.Add(estudiante4);
        DBContext.SaveChanges();


    }
}
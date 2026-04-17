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
        Console.WriteLine("Hello, World!");
    }
}
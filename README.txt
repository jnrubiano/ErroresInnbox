------ PARA GENERAR EL NUGET ------
1. Cambiar opción de Debug a Release.
2. Ingresar en "Propiedades" del proyecto --> "Package" y cambiar la versión.
3. Ingresar al explorador de windows en la carpeta donde se empaqueto el nuget.
4. Descargar nuget.exe y ponerlo en la carpeta.
5. Ejecutar en el cmd el siguiente comando:
.\nuget push co.edu.javeriana.errores.1.0.0.nupkg API_KEY -Source https://api.nuget.org/v3/index.json


------ PARA IMPORTAR EL NUGET ------
1. Ingresar en visual studio a "Herramientas" --> "Administrador de paquetes de Nuget" --> "Administrar paquetes de NuGet para la solución..."
2. Buscar co.edu.javeriana.errores y verificar que la versión del NuGet coincida con la del punto 2 de la generación del NuGet
3. Añadir using co.edu.javeriana.errores; para importar la libreria en el proyecto.
4.  Usar el siguiente código para obtener los códigos y descripciones de error

private static void Main(string[] args)
    {
        Usuario usuario = new Usuario();
        Error e1 = usuario.RecuperarError(Usuario.TipoError.NoInsertar);
        Console.WriteLine("Descripción: "+e1.Descripcion);
        Console.WriteLine("Código error: " + e1.CodEerror);
        Console.ReadLine();
    }
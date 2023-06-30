using Proyectoconjoaco.Clases;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Autor: Joaquin David, 27 de junio, parte del Main con funciones, listas
        GestionSuscripciones gestionSuscripciones = new GestionSuscripciones();
        GestionPaquetes gestionPaquetes = new GestionPaquetes();
        GestionUsuarios gestionUsuarios = new GestionUsuarios();
        GestionPeliculas gestionPeliculas = new GestionPeliculas();
        Catalogo catalogo = new Catalogo();


        Paquete paquete1 = new Paquete("Paquete Básico", 9.99);
        Paquete paquete2 = new Paquete("Paquete Estándar", 19.99);
        Paquete paquete3 = new Paquete("Paquete Premium", 29.99);

        gestionPaquetes.AgregarPaquete(paquete1);
        gestionPaquetes.AgregarPaquete(paquete2);
        gestionPaquetes.AgregarPaquete(paquete3);


        Pelicula pelicula1 = new Pelicula( "Amor y Frijoles", 180, "Clasificación R", "Una pelicula de amol y flijoles");
        Pelicula pelicula2 = new Pelicula( "Iwiwi: El Regreso de Liko",180, "Suspenso", "Una pelicula bien otoreña");
        Pelicula pelicula3 = new Pelicula("Chavez: Un amor de temporada", 200, "Drama, +18, Suspenso", "Una pelicula bien Sad");
        Pelicula pelicula4 = new Pelicula("Destinos Efímeros", 115, "Comedia trágica", " Juan Marcia, un joven enamoradizo, busca el amor verdadero mientras lidia con las tragedias del destino");

        gestionPeliculas.AgregarPelicula(pelicula1);
        gestionPeliculas.AgregarPelicula(pelicula2);
        gestionPeliculas.AgregarPelicula(pelicula3);
        gestionPeliculas.AgregarPelicula(pelicula4);


        // Autor: Lisandro Adolfo, 30 de junio, un while, y switch para poder acceder desde consola e ingresar los datos correspondientes
        while (true)
        {
            Console.WriteLine("Bienvenido al Gestor de Películas Online");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Suscripciones");
            Console.WriteLine("2. Paquetes");
            Console.WriteLine("3. Peliculas");
            Console.WriteLine("4. Usuarios");
            Console.WriteLine("5. Catálogo");
            Console.WriteLine("6. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MostrarMenuSuscripciones(gestionSuscripciones);
                    break;
                case "2":
                    MostrarMenuPaquetes(gestionPaquetes);
                    break;
                case "3":
                    MostrarMenuPelicula(gestionPeliculas);
                    break;
                case "4":
                    MostrarMenuUsuarios(gestionUsuarios);
                    break;
                case "5":
                    MostrarMenuCatalogo(catalogo);
                    break;
                case "6":
                    Console.WriteLine("Gracias por usar el Gestor de Películas Online. ¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    // Autor: Joaquin David, 30 de junio, parte del ciclo para las suscripciones
    static void MostrarMenuSuscripciones(GestionSuscripciones gestionSuscripciones)
    {
        Console.WriteLine("----- Menú Suscripciones -----");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Agregar Suscripción");
        Console.WriteLine("2. Eliminar Suscripción");
        Console.WriteLine("3. Consultar Suscripciones");
        Console.WriteLine("4. Volver al Menú Principal");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                // falta agregar la funcionalidad
                Console.WriteLine("Funcionalidad no implementada");
                break;
            case "2":
                // falta funcionalidad
                Console.WriteLine("Funcionalidad no implementada");
                break;
            case "3":
                gestionSuscripciones.ConsultarSuscripciones();
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                break;
        }
    }

    // Autor: Joaquin David, 30 junio, lo mismo de arriba pero ahora paquetes
    static void MostrarMenuPaquetes(GestionPaquetes gestionPaquetes)
    {
        Console.WriteLine("----- Menú Paquetes -----");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Agregar Paquete");
        Console.WriteLine("2. Eliminar Paquete");
        Console.WriteLine("3. Consultar Paquetes");
        Console.WriteLine("4. Volver al Menú Principal");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                // falta funcionalidad
                Console.WriteLine("Funcionalidad no implementada");
                break;
            case "2":
                // falta funcionalidad
                Console.WriteLine("Funcionalidad no implementada");
                break;
            case "3":
                gestionPaquetes.ConsultarPaquetes();
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                break;
        }
    }

    // Autor: Joaquin David, 30 junio, lo mismo de arriba pero ahora con la gestion de película
    static void MostrarMenuPelicula(GestionPeliculas gestionPelicula)
    {
        Console.WriteLine("----- Menú Películas -----");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Agregar Película");
        Console.WriteLine("2. Eliminar Película");
        Console.WriteLine("3. Consultar Películas");
        Console.WriteLine("4. Volver al Menú Principal");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                //falta funcionalidad
                Console.WriteLine("Funcionalidad no implementada");
                break;
            case "2":
                //funcion faltante 
                Console.WriteLine("Funcionalidad no implementada");
                break;
            case "3":
                gestionPelicula.ConsultarPeliculas();
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                break;
        }
    }

    // Autor: Joaquin David, 30 junio, lo mismo de arriba 
    static void MostrarMenuUsuarios(GestionUsuarios gestionUsuarios)
    {
        Console.WriteLine("----- Menú Usuarios -----");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Agregar Usuario");
        Console.WriteLine("2. Eliminar Usuario");
        Console.WriteLine("3. Consultar Usuarios");
        Console.WriteLine("4. Volver al Menú Principal");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                // funcion faltante
                Console.WriteLine("Funcionalidad no implementada");
                break;
            case "2":
                // funcion faltante
                Console.WriteLine("Funcionalidad no implementada");
                break;
            case "3":
                gestionUsuarios.ConsultarUsuarios();
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                break;
        }
    }

    // Autor: Joaquin David, 30 junio, lo mismo de arriba 
    static void MostrarMenuCatalogo(Catalogo catalogo)
    {
        Console.WriteLine("----- Menú Catálogo -----");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Agregar Película");
        Console.WriteLine("2. Eliminar Película");
        Console.WriteLine("3. Consultar Películas");
        Console.WriteLine("4. Volver al Menú Principal");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                // funcion faltante
                Console.WriteLine("Funcionalidad no implementada");
                break;
            case "2":
                // funcuin faltante
                Console.WriteLine("Funcionalidad no implementada");
                break;
            case "3":
                catalogo.ConsultarPeliculas();
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                break;
        }
    }
}

using Ejercicio1_T3_;

public class Program
{
    private static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Crear Cita");
            Console.WriteLine("2. Listar Citas");
            Console.WriteLine("3. Modificar Masivo");
            Console.WriteLine("4. Fin");
            Console.WriteLine("Seleccione una opción: ");
            opcion = scanner.nextInt();
            scanner.nextLine(); // Limpiar el buffer

            switch (opcion)
            {
                case 1:
                    Citautil.crearlista();
                    break;
                case 2:
                    Citautil.listarCitas();
                    break;
                case 3:
                    Citautil.modificarMasivo();
                    break;
                case 4:
                    Console.WriteLine("Fin del programa.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
            }

            Console.WriteLine(); // Línea en blanco para mejor legibilidad
        } while (opcion != 4);

        scanner.close();
    }
}
    

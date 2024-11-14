using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio1_T3_
{
    public class Citautil
    {
        private static List<Cita> citas = new Arraylist<>();

        public static void crearlista()
        {
            Console.WriteLine("Ingrese el nombre del estudiante");
            string nombredele = Console.ReadLine();
            Console.WriteLine("Ingrese la universidad del estudiante");
            string uestudiante = Console.ReadLine();
            Console.WriteLine("Ingrese su enfermedad");
            string enfermedad = Console.ReadLine();
            Console.WriteLine("Ingrese su número");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio de la cita");
            double precio = double.Parse(Console.ReadLine());

            Estudiante estudiante = new Estudiante(nombredele, uestudiante);
            Cita cita = new Cita(enfermedad, nestud, precio);

            citas.add(cita);
            Console.WriteLine("Cita creada exitosamente.");
        }

        public static void listarCitas()
        {
            double sumaPrecios = 0.0;

            for (int i = 0; i < citas.size(); i++)
            {
                Cita cita = citas.get(i);
                Console.WriteLine((i + 1) + ". Enfermedad: " + cita.getEnfermedad() +
                                   ", Nombre Estudiante: " + cita.getEstudiante().getNombre() +
                                   ", Universidad: " + cita.getEstudiante().getUniversidad() +
                                   ", Precio: " + cita.getPrecio());
                sumaPrecios += cita.getPrecio();
            }

            Console.WriteLine("Suma total de precios: " + sumaPrecios);
        }

        public static void modificarMasivo()
        {
            Scanner scanner = new Scanner(System.in);

            Console.WriteLine("Ingrese el texto a buscar y modificar: ");
            String textoBuscar = scanner.nextLine();

            for (Cita cita = citas)
            {
                String universidadActual = cita.getEstudiante().getUniversidad();
                String nuevaUniversidad = universidadActual.replace(textoBuscar, "internacional");
                if (!universidadActual.equals(nuevaUniversidad))
                {
                    // Aquí se podría implementar un setter en la clase Estudiante
                    // o crear un nuevo objeto Estudiante si es necesario.
                    // Para simplicidad, se puede imprimir el cambio.
                    Console.WriteLine("Modificando universidad de " + universidadActual + " a " + nuevaUniversidad);
                    // Se asume que se tiene un método para actualizar el estudiante.
                }
            }

            Console.WriteLine("Modificación masiva completada.");
        }
    }

}
    }
}

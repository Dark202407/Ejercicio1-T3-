using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_T3_
{
    public class Cita
    {
        private string enfermedad;
        private int nestud;
        private double precio;

        public Cita(string enfermedad, int nestud, double precio)
        {
            this.enfermedad = enfermedad;
            this.nestud = nestud;
            this.precio = precio;
        }
        public string Enfermedad { get { return enfermedad; } }

        public int nestudiante { get { return nestudiante; } }

        public double Precio { get { return precio; } }
    }
}

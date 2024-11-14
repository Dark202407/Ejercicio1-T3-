using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_T3_
{
    public class Estudiante
    {
        private string nom;
        private string uni;

        public Estudiante(string nombre, string universidad)
        {
            this.nom = nombre;
            this.uni = universidad;
        }
        public string nombre { get { return nombre; } }

        public string universidad { get { return universidad;} }

    }
}

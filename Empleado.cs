using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion
{
    internal abstract class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Salario { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Información");
        }
    }
}

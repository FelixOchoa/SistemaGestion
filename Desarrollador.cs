using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion
{
    internal class Desarrollador : Empleado
    {
        private string LenguajeProgramacion { get; set; }
        private int AñosExperiencias { get; set; }

        public void EstablecerLenguaje (string Lenguaje)
        {
            LenguajeProgramacion = Lenguaje;
        }
        public void EstablecerAñosExperiencia (int Años)
        {
            AñosExperiencias = Años;
        }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}" + 
                "\nEdad: {Edad}" + 
                "\nSalario: {Salario}" + 
                "\nLenguaje de Programación: {LenguajeProgramacion}" + 
                "\nAños de Experiencia: {AñosExperiencias}");
        }
        public string RetornarLenguaje()
        {
            return LenguajeProgramacion;
        }

        public int RetornarAño()
        {
            return AñosExperiencias;
        }
    }
}

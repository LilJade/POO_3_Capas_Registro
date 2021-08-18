using System;

namespace Capa_Entidades
{
    public class Entidad_Usuario
    {
        private string nombre;
        private int edad;

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public Entidad_Usuario() { }

        public Entidad_Usuario(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}

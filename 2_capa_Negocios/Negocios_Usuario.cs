using System;
using Capa_Entidades;

namespace _2_capa_Negocios
{
    public class Negocios_Usuario
    {
        // Entidad_Usuario usuario = new Entidad_Usuario();

        public string Registrar(Entidad_Usuario usuario) {

            //Comparar si el usuario tiene un nombre
            if (usuario.Nombre.Equals(""))
            {
                return "Debe ingresar el nombre del usuario!";
            } 
            else if (usuario.Edad <= 0)
            {
                return "Debe ingresar una edad válida (Mayor a cero)!";
            }
            else
            {
                return "El usuario se ha registrado con exito!";
            }
        }
    }
}

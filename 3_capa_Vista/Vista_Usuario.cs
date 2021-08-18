using System;
using Capa_Entidades;
using _2_capa_Negocios;

namespace _3_capa_Vista
{
    class Vista_Usuario
    {
        static void Main(string[] args)
        {

            //Declaramos 2 objetos
            //uno de la Entidad USUARIO
            //el otro será de la Capa de Negocio de Usuarios
            Entidad_Usuario usuario = new Entidad_Usuario();
            Negocios_Usuario negocio = new Negocios_Usuario();

            //Agregamos los datos del usuario
            Console.WriteLine("Ingresar tu nombre:");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad: ");
            string edad = Console.ReadLine();

            if (edad.Equals(""))
            {
                usuario.Edad = 0;
            }
            else {
                usuario.Edad = int.Parse(edad);
            }

            //Registramos el usuario
            string mensaje = negocio.Registrar(usuario);

            //Imprimimos el resultado
            Console.WriteLine(mensaje);
        }
    }
}

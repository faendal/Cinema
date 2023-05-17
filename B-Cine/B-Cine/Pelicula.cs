using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Cine
{
    public class Pelicula
    {
        public enum l_generos
        {
            Accion, Aventura, Animacion, Comedia, Crimen,
            Documental, Drama, Familia, Fantasia, Horror,
            Musical, Misterio, Romance, SciFi, Thriller
        };

        public enum l_edades_minimas { v1 = 7, v2 = 10, v3 = 13, v4 = 15, v5 = 17, v6 = 18 };

        private string nombre;
        private TimeSpan duracion;
        private l_edades_minimas edad_minima;
        private l_generos genero;

        public Pelicula(string nombre, TimeSpan duracion, l_edades_minimas edad_minima, l_generos genero)
        {
            Nombre = nombre;
            Duracion = duracion;
            Edad_minima = edad_minima;
            Genero = genero;
        }

        public string Nombre
        {
            get => nombre;
            set
            { 
                try
                {
                    if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value)) nombre = value;
                    else throw new Exception("Ingrese un nombre válido");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando el nombre a la película\n" + error); }
            }
        }

        public TimeSpan Duracion 
        {
            get => duracion; 
            set
            {
                try
                {
                    if (value > TimeSpan.FromMinutes(45) && value < TimeSpan.FromMinutes(500)) duracion = value;
                    else throw new Exception("Ingrese una duración válida para la película");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando la duración\n" + error); }
            }
        }

        public l_edades_minimas Edad_minima
        {
            get => edad_minima;
            set
            {
                try
                {
                    if (Enum.IsDefined(typeof(l_edades_minimas), value)) edad_minima = value;
                    else throw new Exception("Ingrese una edad mínima consistente con las clasificaciones de la ESRB");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando la edad mínima\n" + error); }
            }
        }

        public l_generos Genero 
        { 
            get => genero;
            set
            {
                try
                {
                    if (Enum.IsDefined(typeof(l_generos), value)) genero = value;
                    else throw new Exception("Ingrese un género válido");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando el género de la película\n" + error); }
            }
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}

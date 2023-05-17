using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Cine
{
    public class Funcion
    {
        public static ushort numeracion_funciones = 1;

        private ushort codigo;
        private DateTime fecha_hora;
        private Sala sala;
        private Pelicula pelicula;
        private ushort boletas_general;
        private ushort boletas_preferencial;

        public Funcion(DateTime fecha_hora, Sala sala, Pelicula pelicula)
        {
            codigo = numeracion_funciones;
            numeracion_funciones++;
            Fecha_hora = fecha_hora;
            Sala = sala;
            Pelicula = pelicula;
            Boletas_general = Sala.Sillas_general;
            Boletas_preferencial = Sala.Sillas_preferencial;
        }

        public DateTime Fecha_hora 
        {
            get => fecha_hora; 
            set
            {
                try
                {
                    if (value >= DateTime.Now && value <= DateTime.Now.AddDays(45)) fecha_hora = value;
                    else throw new Exception("Ingrese una fecha válida para la función");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando la fecha y hora de la función\n" + error); }
            }
        }

        public Sala Sala 
        { 
            get => sala; 
            set
            {
                try
                {
                    if (value is Sala) sala = value;
                    else throw new Exception("Ingrese una instancia de Sala");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando la sala\n" + error); }
            }
        }

        public Pelicula Pelicula 
        { 
            get => pelicula;
            set
            {
                try
                {
                    if (value is Pelicula) pelicula = value;
                    else throw new Exception("Ingrese una instancia de Película");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando la película\n" + error); }
            }
        }

        public ushort Boletas_general 
        { 
            get => boletas_general;
            set
            {
                try
                {
                    if (value >= 0 && value <= Sala.Sillas_general) boletas_general = value;
                    else throw new Exception("No quedan boletas generales disponibles para esta función");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando las boletas generales\n" + error); }
            }
        }

        public ushort Boletas_preferencial 
        { 
            get => boletas_preferencial; 
            set
            {
                try
                {
                    if (value >= 0 && value <= Sala.Sillas_preferencial) boletas_preferencial = value;
                    else throw new Exception("No quedan boletas preferenciales disponibles para esta función");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando las boletas preferenciales\n" + error); }
            }
        }

        public override string ToString()
        {
            return sala.ToString() + ": " + pelicula.ToString() + " - " + Fecha_hora;
        }
    }
}

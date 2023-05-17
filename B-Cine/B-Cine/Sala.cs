using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Cine
{
    public class Sala
    {
        public static byte numeracion_salas = 1;

        private byte nro_sala;
        private ushort sillas_general;
        private ushort sillas_preferencial;

        public Sala(ushort sillas_general, ushort sillas_preferencial)
        {
            nro_sala = numeracion_salas;
            numeracion_salas ++;
            Sillas_general = sillas_general;
            Sillas_preferencial = sillas_preferencial;
        }

        public ushort Sillas_general
        {
            get => sillas_general;
            set
            {
                try
                {
                    if (value >= Multiplex.min_general && value <= Multiplex.max_general) sillas_general = value;
                    else throw new Exception("Ingrese una cantidad de sillas generales válida");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando las sillas generales\n" + error); }
            }
        }

        public ushort Sillas_preferencial
        { 
            get => sillas_preferencial;
            set
            {
                try
                {
                    if (value >= Multiplex.min_preferencial && value <= Multiplex.max_preferencial) sillas_preferencial = value;
                    else throw new Exception("Ingrese una cantidad de sillas preferenciales válida");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando las sillas preferenciales\n" + error); }
            }
        }

        public override string ToString()
        {
            return "Sala número " + nro_sala;
        }
    }
}

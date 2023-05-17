using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Cine
{
    public class Taquillero: Persona
    {
        public Taquillero(uint id, string nombre, string numero_contacto, string usuario, string contrasena, float saldo = 0):
        base(id, nombre, numero_contacto, usuario, contrasena, saldo)
        {
            Descuento = Multiplex.descuento_taquillero;
        }

        public void Comprar_boletas(Funcion funcion, byte cantidad_general, byte cantidad_preferencial)
        {
            try
            {
                byte cantidad_total = (byte)(cantidad_general + cantidad_preferencial);
                if (cantidad_total >= 1 && cantidad_total <= 10)
                {
                    if (funcion is Funcion)
                    {
                        if (cantidad_general <= funcion.Boletas_general && cantidad_preferencial <= funcion.Boletas_preferencial)
                        {
                            float deduccion = (cantidad_general * Multiplex.precio_general + cantidad_preferencial * Multiplex.precio_preferencial) * (1 - Descuento);
                            if (Saldo >= deduccion) 
                            {
                                Saldo -= deduccion;
                                funcion.Boletas_general -= cantidad_general;
                                funcion.Boletas_preferencial -= cantidad_preferencial;
                            }
                        }
                        else throw new Exception("No quedan suficientes boletas para completar su solicitud");
                    }
                    else throw new Exception("Debe ingresar una instancia de Función");
                }
                else throw new Exception("Solo puede comprar 10 boletas por operación");
            }
            catch (Exception error) { throw new Exception("Ocurrió un problema comprando boletas de un taquillero\n" + error); }
        }

        public override string ToString() 
        {
            return Nombre;
        }
    }
}

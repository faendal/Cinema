using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace B_Cine
{
    public class Cliente: Persona
    {
        public enum l_categorias { regular, platino, oro }

        private ushort puntos_acumulados;
        private List<uint> CombosCliente;
        private l_categorias categoria;
        private ushort precio_por_punto;

        public Cliente(uint id, string nombre, string numero_contacto, string usuario, string contrasena, float saldo = 0, ushort puntos_acumulados = 0):
        base(id, nombre, numero_contacto, usuario, contrasena, saldo)
        {
            Puntos_acumulados = puntos_acumulados;
            Verificar_categoria();
        }

        public ushort Puntos_acumulados 
        { 
            get => puntos_acumulados;
            set
            {
                try
                {
                    if (value >= 0) puntos_acumulados = value;
                    else throw new Exception("Los puntos no pueden ser negativos");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando los puntos acumulados\n" + error); }
            }
        }

        public l_categorias Categoria 
        { 
            get => categoria; 
            set
            {
                try
                {
                    if (Enum.IsDefined(typeof(l_categorias), value)) categoria = value;
                    else throw new Exception("Ingrese una categoría de cliente válida");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando la categoría\n" + error); }
            }
        }

        public ushort Precio_por_punto
        { 
            get => precio_por_punto;
            set
            {
                try
                {
                    if (value == Multiplex.precio_por_punto_regular || 
                        value == Multiplex.precio_por_punto_platino || 
                        value == Multiplex.precio_por_punto_oro) precio_por_punto = value;
                    else throw new Exception("Ingrese un valor contenido dentro de las opciones del multiplex");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando el precio por punto\n" + error); }
            }
        }

        public virtual void Comprar_Combo(byte combo)
        {
            try
            {
                if (combo >= 0 && combo <= CombosCliente.Count - 1)
                {
                    if (Saldo >= CombosCliente[combo])
                    {
                        Puntos_acumulados += (ushort)(CombosCliente[combo] / Precio_por_punto);
                        Saldo -= CombosCliente[combo];
                        Verificar_categoria();
                    }
                    else throw new Exception("No cuenta con el saldo suficiente para completar la transacción");
                }
                else throw new Exception("Ingrese un código de combo válido para su categoría");
            }
            catch (Exception error) { throw new Exception("Ocurrió un error durante la compra del combo\n" + error); }
        }

        public void Comprar_boletas(Funcion funcion, byte cantidad_general, byte cantidad_preferencial)
        {
            try
            {
                byte cantidad_total = (byte)(cantidad_general + cantidad_preferencial);
                if (cantidad_total >= 1 && cantidad_total <= 20)
                {
                    if (funcion is Funcion)
                    {
                        if (cantidad_general <= funcion.Boletas_general && cantidad_preferencial <= funcion.Boletas_preferencial)
                        {
                            float deduccion = (cantidad_general * Multiplex.precio_general + cantidad_preferencial * Multiplex.precio_preferencial) * (1 - Descuento);
                            if (Saldo >= deduccion)
                            {
                                Saldo -= deduccion;
                                Puntos_acumulados += (ushort)(cantidad_general + 2 * cantidad_preferencial);
                                funcion.Boletas_general -= cantidad_general;
                                funcion.Boletas_preferencial -= cantidad_preferencial;
                                Verificar_categoria();
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

        public void Verificar_categoria()
        {
            try
            {
                if (Puntos_acumulados < 100)
                {
                    Categoria = l_categorias.regular;
                    Descuento = Multiplex.descuento_regular;
                    Precio_por_punto = Multiplex.precio_por_punto_regular;
                    CombosCliente = new List<uint> 
                    {
                        Multiplex.combo1,
                        Multiplex.combo2,
                        Multiplex.combo3 
                    };
                }
                if (Puntos_acumulados >= 100 && Puntos_acumulados < 150)
                {
                    Categoria = l_categorias.platino;
                    Descuento = Multiplex.descuento_platino;
                    Precio_por_punto = Multiplex.precio_por_punto_platino;
                    CombosCliente = new List<uint>
                    {
                        Multiplex.combo1,
                        Multiplex.combo2,
                        Multiplex.combo3,
                        Multiplex.combo4
                    };
                }
                if (Puntos_acumulados >= 150)
                {
                    Categoria = l_categorias.oro;
                    Descuento = Multiplex.descuento_oro;
                    Precio_por_punto = Multiplex.precio_por_punto_oro;
                    CombosCliente = new List<uint>
                    {
                        Multiplex.combo1,
                        Multiplex.combo2,
                        Multiplex.combo3,
                        Multiplex.combo4,
                        Multiplex.combo5
                    };
                }
            }
            catch (Exception error) { throw new Exception("Ocurrió un error verificando la categoría\n" + error); }
        }

        public override string ToString()
        {
            return Usuario;
        }
    }
}

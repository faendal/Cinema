using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace B_Cine
{
    internal class Multiplex
    {
        public static readonly ushort min_duracion = 45;
        public static readonly ushort max_duracion = 500;
        public static readonly float descuento_taquillero = 0.3f;
        public static readonly float descuento_regular = 0f;
        public static readonly float descuento_platino = 0.1f;
        public static readonly float descuento_oro = 0.2f;
        public static readonly int precio_general = 10000;
        public static readonly int precio_preferencial = 15000;
        public static readonly ushort min_general = 35;
        public static readonly ushort max_general = 700;
        public static readonly ushort min_preferencial = 15;
        public static readonly ushort max_preferencial = 300;
        public static readonly byte puntos_platino = 100;
        public static readonly byte puntos_oro = 150;
        public static readonly ushort precio_por_punto_regular = 10000;
        public static readonly ushort precio_por_punto_platino = 5000;
        public static readonly ushort precio_por_punto_oro = 2000;
        public static readonly Dictionary<byte, ushort> CombosMultiplex = new Dictionary<byte, ushort>
        {
            {1, 25000},
            {2, 30000},
            {3, 40000},
            {4, 50000},
            {5, 60000}
        };

        private List<Sala> l_salas;
        private List<Cliente> l_clientes;
        private List<Funcion> l_funciones;
        private List<Pelicula> l_peliculas;
        private List<Taquillero> l_taquilleros;

        public Multiplex()
        {
            l_salas = new List<Sala>();
            l_clientes = new List<Cliente>();
            l_funciones = new List<Funcion>();
            l_peliculas = new List<Pelicula>();
            l_taquilleros = new List<Taquillero>();
        }

        public List<Sala> L_salas { get => l_salas; }
        public List<Cliente> L_clientes { get => l_clientes; }
        public List<Funcion> L_funciones { get => l_funciones; }
        public List<Pelicula> L_peliculas { get => l_peliculas; }
        public List<Taquillero> L_taquilleros { get => l_taquilleros; }

        public Taquillero Contratar_taquillero(uint id, string nombre, string numero_contacto, string usuario, string contrasena)
        {
            try
            {
                Taquillero trabajador = new Taquillero(id, nombre, numero_contacto, usuario, contrasena);
                l_taquilleros.Add(trabajador);
                return trabajador;
            }
            catch(Exception error) { throw new Exception("Ocurrió un error contratando al taquillero\n" + error); }
        }

        public Cliente Crear_cliente(uint id, string nombre, string numero_contacto, string usuario, string contrasena)
        {
            try
            {
                Cliente nuevo_cliente = new Cliente(id, nombre, numero_contacto, usuario, contrasena);
                l_clientes.Add(nuevo_cliente);
                return nuevo_cliente;
            }
            catch (Exception error) { throw new Exception("Ocurrió un error contratando agregando un nuevo cliente\n" + error); }
        }

        public Sala Construir_sala(ushort sillas_generales, ushort sillas_preferenciales)
        {
            try
            {
                Sala nueva_sala = new Sala(sillas_generales, sillas_preferenciales);
                l_salas.Add(nueva_sala); 
                return nueva_sala;
            }
            catch (Exception error) { throw new Exception("Ocurrió un error construyendo la sala\n" + error); }
        }

        public Funcion Crear_funcion(DateTime fecha_hora, Sala sala, Pelicula pelicula)
        {
            try
            {
                Funcion nueva_funcion = new Funcion(fecha_hora, sala, pelicula);
                l_funciones.Add(nueva_funcion);
                return nueva_funcion;
            }
            catch (Exception error) { throw new Exception("Ocurrió un error creando la función\n" + error); }
        }

        public Pelicula Pasar_pelicula(string nombre, TimeSpan duracion, Pelicula.l_edades_minimas edad_minima, Pelicula.l_generos genero)
        {
            try
            {
                Pelicula nueva_peli = new Pelicula(nombre, duracion, edad_minima, genero);
                l_peliculas.Add(nueva_peli);
                return nueva_peli;
            }
            catch (Exception error) { throw new Exception("Ocurrió un error creando la película\n" + error); }
        }
    }
}

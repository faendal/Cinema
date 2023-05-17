using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Cine
{
    public abstract class Persona
    {
        public enum l_recargas
        {
            v1 = 40000, v2 = 50000, v3 = 60000, v4 = 70000,
            v5 = 80000, v6 = 90000, v7 = 100000, v8 = 120000,
            v9 = 150000, v10 = 200000
        };

        protected uint id;
        protected string nombre;
        protected string numero_contacto;
        private string usuario;
        private string contrasena;
        private float saldo;
        private float descuento;

        public uint Id 
        {
            get => id; 
            set
            {
                try
                {
                    if (value >= 0 && value <= uint.MaxValue) id = value;
                    else throw new Exception("Ingrese un Id válido");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando el Id\n" + error); }
            }
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
                catch (Exception error) { throw new Exception("Ocurrió un error asignando el nombre\n" + error); }
            }
        }

        public string Numero_contacto 
        { 
            get => numero_contacto; 
            set
            {
                try
                {
                    if (!string.IsNullOrEmpty(value) &&
                    !string.IsNullOrWhiteSpace(value) &&
                    value.Length >= 7 &&
                    value.Length <= 15) numero_contacto = value;
                    else throw new Exception("Ingrese un número de contacto válido");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando el número de contacto\n" + error); }
            }
        }

        public string Usuario 
        { 
            get => usuario; 
            set
            {
                try
                {
                    if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value)) usuario = value;
                    else throw new Exception("Ingrese un nombre de usuario válido");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando el nombre de usuario\n" + error); }
            }
        }

        public string Contrasena 
        { 
            get => contrasena;
            set
            {
                try
                {
                    if (!string.IsNullOrEmpty(value) && 
                        !string.IsNullOrWhiteSpace(value) &&
                        value.Length >= 4 && value.Length <= 15) contrasena = value;
                    else throw new Exception("Ingrese una contraseña de entre 4 y 15 caracteres");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando la contraseña\n" + error); }
            }
        }

        public float Saldo 
        {
            get => saldo;
            set
            {
                try
                {
                    if ((value < 0 && value <= Saldo) || value > 0) saldo = value;
                    else throw new Exception("Ingrese un valor que no resulte en un saldo negativo");
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando el saldo\n" + error); }
            }
        }

        public float Descuento
        { 
            get => descuento; 
            set
            {
                try
                {
                    if(value >= 0) descuento = value;
                }
                catch (Exception error) { throw new Exception("Ocurrió un error asignando el descuento\n" + error); }
            }
        }

        protected Persona(uint id, string nombre, string numero_contacto, string usuario, string contrasena, float saldo = 0)
        {
            Id = id;
            Nombre = nombre;
            Numero_contacto = numero_contacto;
            Usuario = usuario;
            Contrasena = contrasena;
            this.saldo = saldo;
        }

        public void Recargar_saldo(l_recargas valor)
        {
            try
            {
                if (Enum.IsDefined(typeof(l_recargas), valor)) saldo += ((float)valor);
                else throw new Exception("Ingrese un valor consistente con los valores disponibles");
            }
            catch (Exception error) { throw new Exception("Ocurrió un error recargando el saldo\n" + error); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Credenciales
    {
        //Atributos
        private string _usuario;
        private string _clave;
        private DateTime _fhcreacion;
        private DateTime _fhmodificacion;
        private int intentos;
        private string _clave_1;
        private string _clave_2;
        private string _clave_3;
        private string _nombre;
        private string _apellido;
        private string _mail;

        //Constructor
        public Credenciales(string[] registro)
        {
            this.Usuario = registro[0];
            this.Clave = registro[1];
            this.FhCreacion = DateTime.Parse(registro[2]);
            this.FhModificacion = DateTime.Parse(registro[3]);
            this.Intentos = int.Parse(registro[4]);
            this.Clave_1 = registro[5];
            this.Clave_2 = registro[6];
            this.Clave_3 = registro[7];
            this.Nombre = registro[8];
            this.Apellido = registro[9];
            this.Mail = registro[10];
        }

        //Propiedades
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public DateTime FhCreacion { get => _fhcreacion; set => _fhcreacion = value; }
        public DateTime FhModificacion { get => _fhmodificacion; set => _fhmodificacion = value; }
        public DateTime FhCaducidad()
        {
            DateTime salida = FhModificacion.AddDays(30);
            return salida;
        }
        public int Intentos { get => intentos; set => intentos = value; }
        public string Clave_1 { get => _clave_1; set => _clave_1 = value; }
        public string Clave_2 { get => _clave_2; set => _clave_2 = value; }
        public string Clave_3 { get => _clave_3; set => _clave_3 = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Mail { get => _mail; set => _mail = value; }

        public Boolean validarNuevaClave(string clave_nueva)
        {
            Boolean salida = true;
            if (clave_nueva == Clave || clave_nueva == Clave_1 || clave_nueva == Clave_2 || clave_nueva == Clave_3)
            {
                salida = false;
            }
            return salida;
        }

        public Boolean usrBloqueado()
        {
            Boolean salida = false;
            if (Intentos >= 3)
            {
                salida = true;
            }
            return salida;
        }
        
        public Boolean claveCaducada()
        {
            Boolean salida = false;
            if (FhCaducidad() < DateTime.Now)
            {
                salida = true;
            }
            return salida;
        }

        public String[] ToStringCSV()
        {
            String[] salida = new String[11];

            salida[0] = this.Usuario;
            salida[1] = this.Clave;
            salida[2] = this.FhCreacion.ToString("yyyy-MM-dd");
            salida[3] = this.FhModificacion.ToString("yyyy-MM-dd");
            salida[4] = this.Intentos.ToString();
            salida[5] = this.Clave_1;
            salida[6] = this.Clave_2;
            salida[7] = this.Clave_3;
            salida[8] = this.Nombre;
            salida[9] = this.Apellido;
            salida[10] = this.Mail;

            return salida;
        }
        public String ToCSV()
        {
            return this.Usuario + ";" + this.Clave + ";" + this.FhCreacion.ToString("yyyy-MM-dd") + ";" 
                + this.FhModificacion.ToString("yyyy-MM-dd") + ";" + this.Intentos.ToString() + ";"
                + this.Clave_1 + ";" + this.Clave_2 + ";" + this.Clave_3 + ";"
                + this.Nombre + ";" + this.Apellido + ";" + this.Mail;
        }
    }
}

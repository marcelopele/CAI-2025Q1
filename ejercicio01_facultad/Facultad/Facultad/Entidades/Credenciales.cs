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
        private DateTime _fhcaducidad;
        private int intentos;
        private string _clave_1;
        private string _clave_2;
        private string _clave_3;
        private string _nombre;
        private string _apellido;
        private string _mail;


        //Contructor con csv
        public Credenciales(string registro)
        {
            String[] datos = registro.Split(';');
            this.Usuario = datos[0];
            this.Clave = datos[1];
            this.FhCreacion = DateTime.Parse(datos[2]);
            this.FhModificacion = DateTime.Parse(datos[3]);
            this.FhCaducidad = DateTime.Parse(datos[4]);
            this.Intentos = int.Parse(datos[5]);
            this.Clave_1 = datos[6];
            this.Clave_2 = datos[7];
            this.Clave_3 = datos[8];
            this.Nombre = datos[9];
            this.Apellido = datos[10];
            this.Mail = datos[11];
        }

        //Propiedades
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public DateTime FhCreacion { get => _fhcreacion; set => _fhcreacion = value; }
        public DateTime FhModificacion { get => _fhmodificacion; set => _fhmodificacion = value; }
        public DateTime FhCaducidad { get => _fhcaducidad; set => _fhcaducidad = value; }
        public int Intentos { get => intentos; set => intentos = value; }
        public string Clave_1 { get => _clave_1; set => _clave_1 = value; }
        public string Clave_2 { get => _clave_2; set => _clave_2 = value; }
        public string Clave_3 { get => _clave_3; set => _clave_3 = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Mail { get => _mail; set => _mail = value; }



    }
}

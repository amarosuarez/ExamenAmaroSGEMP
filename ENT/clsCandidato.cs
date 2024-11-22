using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class clsCandidato
    {

        #region Atributos
        private int id;
        private string nombre;
        private string apellidos;
        private string direccion;
        private string pais;
        private string telefono;
        private DateTime fechaNac;
        private int precioMedio;
        private int edad;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
            }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { 
                if (!string.IsNullOrEmpty(value))
                {
                    apellidos = value;
                }
            }
        }

        public string Direccion
        {
            get { return direccion; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    direccion = value;
                }
            }
        }

        public string Pais
        {
            get { return pais; }
            set { 
                if (!string.IsNullOrEmpty(value))
                {
                    pais = value;
                }
            }
        }

        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    telefono = value;
                }
            }
        }

        public DateTime FechaNac
        {
            get { return fechaNac; }
            set {
                fechaNac = value;
            }
        }

        public int PrecioMedio
        {
            get { return precioMedio; }
            set
            {
                if (value >= 0)
                {
                    precioMedio = value;
                }
            }
        }

        public int Edad
        {
            get { return getEdad(); }
        }
        #endregion

        #region Constructores
        public clsCandidato(int id, string nombre, string apellidos, string direccion, string pais, string telefono, string fechaNac, int precioMedio)
        {
            if (id > 0)
            {
                this.id = id;
            }

            if (!string.IsNullOrEmpty (nombre))
            {
                this.nombre = nombre;
            }

            if (!string.IsNullOrEmpty(apellidos))
            {
                this.apellidos = apellidos;
            }

            if (!string.IsNullOrEmpty(direccion))
            {
                this.direccion = direccion;
            }

            if (!string.IsNullOrEmpty(pais))
            {
                this.pais = pais;
            }

            if (!string.IsNullOrEmpty(telefono))
            {
                this.telefono = telefono;
            }

            if (!string.IsNullOrEmpty(fechaNac))
            {
                DateTime date = DateTime.Parse(fechaNac);
                this.fechaNac = date;
            }

            if (precioMedio >= 0)
            {
                this.precioMedio = precioMedio;
            }
        }
        #endregion

        #region Funciones
        /// <summary>
        /// Función que calcula la edad actual del candidato
        /// <br></br>
        /// Pre: Ninguna
        /// <br></br>
        /// Post: Ninguna
        /// </summary>
        /// <returns>Edad actual del candidato</returns>
        public int getEdad()
        {
            int edad = DateTime.Now.Year - fechaNac.Year;
            return edad;
        }
        #endregion
    }
}

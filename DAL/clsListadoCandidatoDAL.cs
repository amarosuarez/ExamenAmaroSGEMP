using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsListadoCandidatoDAL
    {
        // Es internal para poder usarla en la clase clsListadoMisionDAL
        internal static List<clsCandidato> candidatos = new List<clsCandidato>
        {
            new clsCandidato(1, "Vito", "Gordon", "Pizza Street, 1232", "USA", "54567686", "10/11/1961", 2500),
            new clsCandidato(2, "Christopher", "Moltisanti", "St Monti Av", "USA", "568765466", "22/03/2000", 1500),
            new clsCandidato(3, "Braulia", "Galliani", "Brooklyn Av", "USA", "5679321", "09/12/1998", 1500),
            new clsCandidato(4, "Paulie", "Gualtieri", "Soprano Street, 5", "USA", "65783287", "24/07/1968", 2000),
            new clsCandidato(5, "Estás", "Caputo", "Via Bonna Sera, 14", "Italia", "65434567", "02/06/1973", 20000),
            new clsCandidato(6, "Toco", "L'Acordeone", "Via Musica, 20", "Italia", "6787654", "12/03/1984", 14000),
            new clsCandidato(7, "Luigi", "Peperoni", "Piaza Roma, 3", "Italia", "56767665", "05/04/1999", 16000),
            new clsCandidato(8, "Silvio", "Dante", "Town Street, 56", "USA", "87676765", "30/01/1966", 2000),
        };   
        
        /// <summary>
        /// Función que devuelve un listado de candidatos
        /// <br></br>
        /// Pre: Ninguna
        /// <br></br>
        /// Post: Puede devolver una lista vacia si no encuentra candidatos
        /// </summary>
        /// <returns>Listado de candidatos</returns>
        public static List<clsCandidato> obtenerListadoCandidatosDAL() {
            return candidatos;
        }

        /// <summary>
        /// Función que devuelve un candidato por su ID
        /// <br></br>
        /// Pre: El ID debe ser mayor que 0
        /// <br></br>
        /// Post: Puede devolver null si no se encuentra un candidato con ese ID
        /// </summary>
        /// <param name="id">ID del candidato a buscar</param>
        /// <returns>Objeto candidato</returns>
        public static clsCandidato? obtenerCandidatoPorIdDAL(int id)
        {
            return candidatos.Find(candidato => candidato.Id == id);
        }
    }
}

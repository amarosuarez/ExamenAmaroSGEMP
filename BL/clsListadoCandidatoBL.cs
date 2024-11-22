using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;

namespace BL
{
    public class clsListadoCandidatoBL
    {
        /// <summary>
        /// Función que devuelve un listado de candidatos
        /// <br></br>
        /// Pre: Ninguna
        /// <br></br>
        /// Post: Puede devolver una lista vacia si no encuentra candidatos
        /// </summary>
        /// <returns>Listado de candidatos</returns>
        public static List<clsCandidato> obtenerListadoCandidatosBL()
        {
            return clsListadoCandidatoDAL.obtenerListadoCandidatosDAL();
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
        public static clsCandidato? obtenerCandidatoPorIdBL(int id)
        {
            return clsListadoCandidatoDAL.obtenerCandidatoPorIdDAL(id);
        }

    }
}

using DAL;
using ENT;

namespace BL
{
    public class clsListadoMisionBL
    {
        /// <summary>
        /// Función que devuelve un listado de misiones
        /// <br></br>
        /// Pre: Ninguna
        /// <br></br>
        /// Post: Puede devolver una lista vacia si no encuentra misiones
        /// </summary>
        /// <returns>Listado de misiones</returns>
        public static List<clsMision> obtenerListadoMisionesBL()
        {
            return clsListadoMisionDAL.obtenerListadoMisionesDAL();    
        }

        /// <summary>
        /// Función que devuelve una misión por su ID
        /// <br></br>
        /// Pre: El ID debe ser mayor que 0
        /// <br></br>
        /// Post: Puede devolver null si no se encuentra una misión con ese ID
        /// </summary>
        /// <param name="id">ID de la misión a buscar</param>
        /// <returns>Objeto mision</returns>
        public static clsMision? obtenerMisionPorIdBL(int id)
        {
            return clsListadoMisionDAL.obtenerMisionPorIdDAL(id);   
        }

        /// <summary>
        /// Función que dependiendo de la dificultad de la misión selecciona
        /// unos candidatos por su edad y país y los devuelve como un listado
        /// <br></br>
        /// Pre: El id debe ser mayor que 0
        /// <br></br>
        /// Post: Puede devolver un listado vacío si no encuentra la misión
        /// </summary>
        /// <param name="id">Id de la misión</param>
        /// <returns>Listado de candidatos</returns>
        public static List<clsCandidato> candidatosValidosParaMision(int id)
        {
            List<clsCandidato> candidatosFinales = new List<clsCandidato>();

            // Obtengo todos los candidatos para luego hacer el filtrado
            List<clsCandidato> candidatos = clsListadoCandidatoBL.obtenerListadoCandidatosBL();

            clsMision? mision = obtenerMisionPorIdBL(id);

            if (mision != null) {

                switch (mision.Dificultad)
                {
                    case 1:
                    case 2:
                        candidatosFinales = candidatos.Where(c => c.Pais.ToLower() == "usa").ToList();
                        break;
                    case 3:
                        candidatosFinales = candidatos.Where(c => c.Pais.ToLower() == "usa" && c.Edad > 40).ToList();
                        break;
                    case 4:
                        candidatosFinales = candidatos.Where(c => c.Pais.ToLower() == "italia" && c.Edad < 45).ToList();
                        break;
                    case 5:
                        candidatosFinales = candidatos.Where(c => c.Pais.ToLower() == "italia" && (c.Edad > 45 && c.Edad < 55)).ToList();
                        break;
                }
            }

            return candidatosFinales;
        }
    }
}

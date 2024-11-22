using ENT;

namespace DAL
{
    public class clsListadoMisionDAL
    {
        private static List<clsMision> misiones = new List<clsMision>{
            new clsMision(1, "Recoger impuestos en el restaurante", 1),
            new clsMision(2, "Hacer una oferta que no puedan rechazar al sindicato de basura", 2),
            new clsMision(3, "Supervisar obras en New Jersey", 3),
            new clsMision(4, "Convencer a Concejal de urbanismo para conseguir favores", 4),
            new clsMision(5, "Encargarse del concejal de urbanismo que no se dejó convencer", 5),
            new clsMision(6, "Llevar la contabilidad del Bada Bing", 1)
        };

        /// <summary>
        /// Función que devuelve un listado de misiones
        /// <br></br>
        /// Pre: ninguna
        /// <br></br>
        /// Post: Puede devolver una lista vacía no se encuentra ninguna mision
        /// </summary>
        /// <returns>Lista de misiones</returns>
        public static List<clsMision> obtenerListadoMisionesDAL()
        {
            return misiones;
        }

        /// <summary>
        /// Función que obtiene una misión de la lista de misiones por su ID
        /// <br></br>
        /// Pre: El id debe ser mayor que 0
        /// <br></br>
        /// Post: Puede devolver null si no encuentra la misión
        /// </summary>
        /// <param name="id">Id de la misión a buscar</param>
        /// <returns>Objeto Mision</returns>
        public static clsMision? obtenerMisionPorIdDAL(int id)
        {
            return misiones.Find(mision => mision.Id == id);
        }

        /// <summary>
        /// Función que devuelve un listado de candidatos válidos para una misión
        /// </summary>
        /// <returns>Listdo de candidatos</returns>
        public static List<clsCandidato> candidatosValidosParaMisionDAL()
        {
            // En este caso, no le paso el id de la misión porque me va a devolver todos los candidatos
            // y ya luego, en la BL, si se lo pasaría ya que ahí es donde se hace el filtrado
            //TODO
            return clsListadoCandidatoDAL.candidatos;
        }
    }
}

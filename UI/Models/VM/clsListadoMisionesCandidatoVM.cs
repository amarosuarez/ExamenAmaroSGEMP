using BL;
using ENT;

namespace UI.Models.VM
{
    public class clsListadoMisionesCandidatoVM : clsMision
    {
        #region Atributos
        private List<clsMision> misiones;
        private List<clsCandidato> candidatos;
        #endregion

        #region Propiedades
        public List<clsMision> Misiones { get { return misiones; } }
        public List<clsCandidato> Candidatos { get { return candidatos; } }
        #endregion

        #region Constructores
        public clsListadoMisionesCandidatoVM()
        {
            misiones = clsListadoMisionBL.obtenerListadoMisionesBL();
        }

        public clsListadoMisionesCandidatoVM(int id) : this()
        {
            clsMision? mision = clsListadoMisionBL.obtenerMisionPorIdBL(id);
            if (mision != null)
            {
                candidatos = clsListadoMisionBL.candidatosValidosParaMision(id);
                this.Id = id;
                this.Nombre = mision.Nombre;
                this.Dificultad = mision.Dificultad;
            }
        }
        #endregion
    }
}

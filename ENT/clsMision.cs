namespace ENT
{
    public class clsMision
    {
        #region Atributos
        private int id;
        private string nombre;
        private int dificultad;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return id; }
            set {
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

        public int Dificultad
        {
            get { return dificultad; }
            set
            {
                if (value > 0)
                {
                    dificultad = value;
                }
            }
        }
        #endregion

        #region Constructores
        public clsMision() { }
        public clsMision(int id, string nombre, int dificultad)
        {
            if (id > 0)
            {
                this.id = id;
            }

            if (!string.IsNullOrEmpty (nombre))
            {
                this.nombre = nombre;
            }

            if (dificultad > 0)
            {
                this.dificultad = dificultad;
            }
        }
        #endregion
    }
}

namespace IVR.Entity
{
    public class Encuesta
    {

        private string descripcionEncuesta { get; set; }

        public Encuesta(string descripcion)
        {
            this.descripcionEncuesta = descripcion;
        }

        public string getDescripcionEncuesta() {
            return this.descripcionEncuesta;
        }
    }
}
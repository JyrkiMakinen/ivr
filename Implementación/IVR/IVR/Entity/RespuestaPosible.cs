namespace IVR.Entity
{
    public class RespuestaPosible
    {

        private string descripcion { get; set; }
        private Pregunta pregunta;

        public RespuestaPosible(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string getDescripcion() {
            return this.descripcion;
        }

        public string obtenerDescripcionPregunta() {
            return this.pregunta.getDescripcionPregunta();
        }

        public string obtenerDescripcionEncuesta() {
            return this.pregunta.obtenerDescripcionEncuesta();
        }
    }
}
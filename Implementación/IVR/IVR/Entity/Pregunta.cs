namespace IVR.Entity
{
    public class Pregunta
    {

        private string descripcionPregunta { get; set; }
        private Encuesta encuesta;

        public Pregunta(string descripcion)
        {
            this.descripcionPregunta = descripcion;
        }

        public string getDescripcionPregunta() {
            return this.descripcionPregunta;
        }

        public string obtenerDescripcionEncuesta() {
            return this.encuesta.getDescripcionEncuesta();
        }

    }
}
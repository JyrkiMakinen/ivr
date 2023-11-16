using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IVR.Entity
{
    public class Pregunta
    {
        // Atributos
        [Key]
        public int PreguntaId { get; set; } // Fabricacion pura

        public string Descripcion { get; set; }

        public List<RespuestaPosible> RespuestaPosibless { get; set; }

        [ForeignKey("Encuesta")]
        public int? EncuestaId { get; set; } // Fabricacion pura
        public Encuesta Encuesta { get; set; } // Fabricacion pura


        // Metodos
        public Pregunta(string descripcion, List<RespuestaPosible> respuestasPosibles)
        {
            this.Descripcion = descripcion;
            this.RespuestaPosibless = respuestasPosibles;
        }

        public bool esTuRespuesta(RespuestaPosible respuesta)
        {
            if (RespuestaPosibless.Contains(respuesta))
            {
                return true;
            }
            return false;
        }

        public string obtenerDescripcionPregunta(ref string descripcionEncuesta, List<Encuesta> allEncuestas) 
        {
            foreach (Encuesta encuesta in allEncuestas)
            {
                if (encuesta.esTuPregunta(this))
                {
                    descripcionEncuesta = encuesta.getDescripcionEncuesta(); // Recién en este punto se obtiene la descripción de la encuesta
                    break;
                }
            }

            return Descripcion;
        }
    }
}
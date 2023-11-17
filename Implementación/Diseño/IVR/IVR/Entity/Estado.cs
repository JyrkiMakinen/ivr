using System.ComponentModel.DataAnnotations;

namespace IVR.Entity
{
    public class Estado
    {
        // Atributos
        [Key]
        public int EstadoId { get; set; } // Fabricacion pura

        public string Nombre { get; set; }


        // Metodos
        public Estado(string nombre)
        {
            this.Nombre = nombre;
        }

        public Estado() { }

        public bool esIniciada()
        {
            return getNombre() == "Iniciada";
        }

        public string getNombre() {
            return Nombre;
        }
    }
}
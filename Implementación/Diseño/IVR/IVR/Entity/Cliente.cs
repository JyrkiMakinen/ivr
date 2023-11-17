using System.ComponentModel.DataAnnotations;

namespace IVR.Entity
{
    public class Cliente
    {
        // Atributos
        [Key]
        public int ClienteId { get; set; }

        public string Nombre { get; set; }


        // Metodos
        public Cliente(string nombre)
        {
            this.Nombre = nombre;
        }

        public Cliente() { }

        public string getNombre()
        {
            return Nombre;
        }
    }
}
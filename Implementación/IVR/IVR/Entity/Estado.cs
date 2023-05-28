namespace IVR.Entity
{
    public class Estado
    {

        private string nombre { get; set; }

        public Estado(string nombre)
        {
            this.nombre = nombre;
        }

        public bool esIniciada()
        {
            return this.getNombre() == "Iniciada";
        }

        public bool esFinalizada()
        {
            return this.getNombre() == "Finalizada";
        }

        public string getNombre() {
            return this.nombre;
        }
    }
}
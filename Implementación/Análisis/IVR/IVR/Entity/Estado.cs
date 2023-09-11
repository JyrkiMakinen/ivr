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
            return getNombre() == "Iniciada";
        }

        public string getNombre() {
            return nombre;
        }
    }
}
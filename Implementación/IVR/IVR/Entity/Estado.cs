namespace IVR.Entity
{
    public class Estado
    {

        private string nombre { get; set; }

        public Estado(string nombre, bool esIniciada)
        {
            this.nombre = nombre;
            this.esIniciada = esIniciada;
        }

        public bool esIniciada()
        {
            // Implementación del método tieneEncuestasRespondidas
            // Aquí puedes agregar la lógica que determine si la llamada tiene encuestas respondidas
            // Por ahora, el método está vacío y siempre devuelve false
            return false;
        }
    }
}
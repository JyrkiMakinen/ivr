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
            // Implementaci�n del m�todo tieneEncuestasRespondidas
            // Aqu� puedes agregar la l�gica que determine si la llamada tiene encuestas respondidas
            // Por ahora, el m�todo est� vac�o y siempre devuelve false
            return false;
        }
    }
}
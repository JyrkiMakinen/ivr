namespace IVR.Entity
{
    public class Cliente
    {
        private string nombre;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return nombre;
        }
    }
}
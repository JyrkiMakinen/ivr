using IVR.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.Datos
{
    public class IVRDbContext : DbContext
    {
        public DbSet<CambioEstado> CambioEstados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Encuesta> Encuestas { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Llamada> Llamadas { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<RespuestaDeCliente> RespuestasDeClientes { get; set; }
        public DbSet<RespuestaPosible> RespuestaPosibles { get; set; }

        static IVRDbContext()
        {
            Database.SetInitializer<IVRDbContext>(new DropCreateDatabaseIfModelChanges<IVRDbContext>());
        }
    }
}

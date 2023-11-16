using IVR.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.Persistencia
{
    public class IVRDbContext : DbContext
    {
        DbSet<CambioEstado> cambioEstados { get; set; }
        DbSet<Cliente> clientes { get; set; }
        DbSet<Encuesta> encuestas { get; set; }
        DbSet<Estado> estados { get; set; }
        DbSet<Llamada> llamadas { get; set; }
        DbSet<Pregunta> preguntas { get; set; }
        DbSet<RespuestaDeCliente> respuestasDeClientes { get; set; }
        DbSet<RespuestaPosible> respuestaPosibles { get; set; }

        static IVRDbContext()
        {
            Database.SetInitializer<IVRDbContext>(new DropCreateDatabaseIfModelChanges<IVRDbContext>());
        }
    }
}

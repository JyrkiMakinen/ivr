namespace IVR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CambioEstadoes",
                c => new
                    {
                        CambioEstadoId = c.Int(nullable: false, identity: true),
                        FechaHoraInicio = c.DateTime(nullable: false),
                        FechaHoraFin = c.DateTime(),
                        EstadoId = c.Int(nullable: false),
                        LlamadaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CambioEstadoId)
                .ForeignKey("dbo.Estadoes", t => t.EstadoId, cascadeDelete: true)
                .ForeignKey("dbo.Llamadas", t => t.LlamadaId, cascadeDelete: true)
                .Index(t => t.EstadoId)
                .Index(t => t.LlamadaId);
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        EstadoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.EstadoId);
            
            CreateTable(
                "dbo.Llamadas",
                c => new
                    {
                        LlamadaId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        Duracion = c.Time(nullable: false, precision: 7),
                        EncuestaEnviada = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LlamadaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.RespuestaDeClientes",
                c => new
                    {
                        RespuestaDeClienteId = c.Int(nullable: false, identity: true),
                        RespuestaPosibleId = c.Int(nullable: false),
                        LlamadaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RespuestaDeClienteId)
                .ForeignKey("dbo.Llamadas", t => t.LlamadaId, cascadeDelete: true)
                .ForeignKey("dbo.RespuestaPosibles", t => t.RespuestaPosibleId, cascadeDelete: true)
                .Index(t => t.RespuestaPosibleId)
                .Index(t => t.LlamadaId);
            
            CreateTable(
                "dbo.RespuestaPosibles",
                c => new
                    {
                        RespuestaPosibleId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Valor = c.Int(nullable: false),
                        PreguntaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RespuestaPosibleId)
                .ForeignKey("dbo.Preguntas", t => t.PreguntaId, cascadeDelete: true)
                .Index(t => t.PreguntaId);
            
            CreateTable(
                "dbo.Preguntas",
                c => new
                    {
                        PreguntaId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        EncuestaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PreguntaId)
                .ForeignKey("dbo.Encuestas", t => t.EncuestaId, cascadeDelete: true)
                .Index(t => t.EncuestaId);
            
            CreateTable(
                "dbo.Encuestas",
                c => new
                    {
                        EncuestaId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        FechaFinVigencia = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EncuestaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CambioEstadoes", "LlamadaId", "dbo.Llamadas");
            DropForeignKey("dbo.RespuestaDeClientes", "RespuestaPosibleId", "dbo.RespuestaPosibles");
            DropForeignKey("dbo.RespuestaPosibles", "PreguntaId", "dbo.Preguntas");
            DropForeignKey("dbo.Preguntas", "EncuestaId", "dbo.Encuestas");
            DropForeignKey("dbo.RespuestaDeClientes", "LlamadaId", "dbo.Llamadas");
            DropForeignKey("dbo.Llamadas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.CambioEstadoes", "EstadoId", "dbo.Estadoes");
            DropIndex("dbo.Preguntas", new[] { "EncuestaId" });
            DropIndex("dbo.RespuestaPosibles", new[] { "PreguntaId" });
            DropIndex("dbo.RespuestaDeClientes", new[] { "LlamadaId" });
            DropIndex("dbo.RespuestaDeClientes", new[] { "RespuestaPosibleId" });
            DropIndex("dbo.Llamadas", new[] { "ClienteId" });
            DropIndex("dbo.CambioEstadoes", new[] { "LlamadaId" });
            DropIndex("dbo.CambioEstadoes", new[] { "EstadoId" });
            DropTable("dbo.Encuestas");
            DropTable("dbo.Preguntas");
            DropTable("dbo.RespuestaPosibles");
            DropTable("dbo.RespuestaDeClientes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Llamadas");
            DropTable("dbo.Estadoes");
            DropTable("dbo.CambioEstadoes");
        }
    }
}

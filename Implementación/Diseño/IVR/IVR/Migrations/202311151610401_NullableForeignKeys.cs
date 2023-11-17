namespace IVR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableForeignKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CambioEstadoes", "EstadoId", "dbo.Estadoes");
            DropForeignKey("dbo.CambioEstadoes", "LlamadaId", "dbo.Llamadas");
            DropForeignKey("dbo.Llamadas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.RespuestaDeClientes", "LlamadaId", "dbo.Llamadas");
            DropForeignKey("dbo.RespuestaDeClientes", "RespuestaPosibleId", "dbo.RespuestaPosibles");
            DropForeignKey("dbo.RespuestaPosibles", "PreguntaId", "dbo.Preguntas");
            DropForeignKey("dbo.Preguntas", "EncuestaId", "dbo.Encuestas");
            DropIndex("dbo.CambioEstadoes", new[] { "EstadoId" });
            DropIndex("dbo.CambioEstadoes", new[] { "LlamadaId" });
            DropIndex("dbo.Llamadas", new[] { "ClienteId" });
            DropIndex("dbo.RespuestaDeClientes", new[] { "RespuestaPosibleId" });
            DropIndex("dbo.RespuestaDeClientes", new[] { "LlamadaId" });
            DropIndex("dbo.RespuestaPosibles", new[] { "PreguntaId" });
            DropIndex("dbo.Preguntas", new[] { "EncuestaId" });
            AlterColumn("dbo.CambioEstadoes", "EstadoId", c => c.Int());
            AlterColumn("dbo.CambioEstadoes", "LlamadaId", c => c.Int());
            AlterColumn("dbo.Llamadas", "ClienteId", c => c.Int());
            AlterColumn("dbo.RespuestaDeClientes", "RespuestaPosibleId", c => c.Int());
            AlterColumn("dbo.RespuestaDeClientes", "LlamadaId", c => c.Int());
            AlterColumn("dbo.RespuestaPosibles", "PreguntaId", c => c.Int());
            AlterColumn("dbo.Preguntas", "EncuestaId", c => c.Int());
            CreateIndex("dbo.CambioEstadoes", "EstadoId");
            CreateIndex("dbo.CambioEstadoes", "LlamadaId");
            CreateIndex("dbo.Llamadas", "ClienteId");
            CreateIndex("dbo.RespuestaDeClientes", "RespuestaPosibleId");
            CreateIndex("dbo.RespuestaDeClientes", "LlamadaId");
            CreateIndex("dbo.RespuestaPosibles", "PreguntaId");
            CreateIndex("dbo.Preguntas", "EncuestaId");
            AddForeignKey("dbo.CambioEstadoes", "EstadoId", "dbo.Estadoes", "EstadoId");
            AddForeignKey("dbo.CambioEstadoes", "LlamadaId", "dbo.Llamadas", "LlamadaId");
            AddForeignKey("dbo.Llamadas", "ClienteId", "dbo.Clientes", "ClienteId");
            AddForeignKey("dbo.RespuestaDeClientes", "LlamadaId", "dbo.Llamadas", "LlamadaId");
            AddForeignKey("dbo.RespuestaDeClientes", "RespuestaPosibleId", "dbo.RespuestaPosibles", "RespuestaPosibleId");
            AddForeignKey("dbo.RespuestaPosibles", "PreguntaId", "dbo.Preguntas", "PreguntaId");
            AddForeignKey("dbo.Preguntas", "EncuestaId", "dbo.Encuestas", "EncuestaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Preguntas", "EncuestaId", "dbo.Encuestas");
            DropForeignKey("dbo.RespuestaPosibles", "PreguntaId", "dbo.Preguntas");
            DropForeignKey("dbo.RespuestaDeClientes", "RespuestaPosibleId", "dbo.RespuestaPosibles");
            DropForeignKey("dbo.RespuestaDeClientes", "LlamadaId", "dbo.Llamadas");
            DropForeignKey("dbo.Llamadas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.CambioEstadoes", "LlamadaId", "dbo.Llamadas");
            DropForeignKey("dbo.CambioEstadoes", "EstadoId", "dbo.Estadoes");
            DropIndex("dbo.Preguntas", new[] { "EncuestaId" });
            DropIndex("dbo.RespuestaPosibles", new[] { "PreguntaId" });
            DropIndex("dbo.RespuestaDeClientes", new[] { "LlamadaId" });
            DropIndex("dbo.RespuestaDeClientes", new[] { "RespuestaPosibleId" });
            DropIndex("dbo.Llamadas", new[] { "ClienteId" });
            DropIndex("dbo.CambioEstadoes", new[] { "LlamadaId" });
            DropIndex("dbo.CambioEstadoes", new[] { "EstadoId" });
            AlterColumn("dbo.Preguntas", "EncuestaId", c => c.Int(nullable: false));
            AlterColumn("dbo.RespuestaPosibles", "PreguntaId", c => c.Int(nullable: false));
            AlterColumn("dbo.RespuestaDeClientes", "LlamadaId", c => c.Int(nullable: false));
            AlterColumn("dbo.RespuestaDeClientes", "RespuestaPosibleId", c => c.Int(nullable: false));
            AlterColumn("dbo.Llamadas", "ClienteId", c => c.Int(nullable: false));
            AlterColumn("dbo.CambioEstadoes", "LlamadaId", c => c.Int(nullable: false));
            AlterColumn("dbo.CambioEstadoes", "EstadoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Preguntas", "EncuestaId");
            CreateIndex("dbo.RespuestaPosibles", "PreguntaId");
            CreateIndex("dbo.RespuestaDeClientes", "LlamadaId");
            CreateIndex("dbo.RespuestaDeClientes", "RespuestaPosibleId");
            CreateIndex("dbo.Llamadas", "ClienteId");
            CreateIndex("dbo.CambioEstadoes", "LlamadaId");
            CreateIndex("dbo.CambioEstadoes", "EstadoId");
            AddForeignKey("dbo.Preguntas", "EncuestaId", "dbo.Encuestas", "EncuestaId", cascadeDelete: true);
            AddForeignKey("dbo.RespuestaPosibles", "PreguntaId", "dbo.Preguntas", "PreguntaId", cascadeDelete: true);
            AddForeignKey("dbo.RespuestaDeClientes", "RespuestaPosibleId", "dbo.RespuestaPosibles", "RespuestaPosibleId", cascadeDelete: true);
            AddForeignKey("dbo.RespuestaDeClientes", "LlamadaId", "dbo.Llamadas", "LlamadaId", cascadeDelete: true);
            AddForeignKey("dbo.Llamadas", "ClienteId", "dbo.Clientes", "ClienteId", cascadeDelete: true);
            AddForeignKey("dbo.CambioEstadoes", "LlamadaId", "dbo.Llamadas", "LlamadaId", cascadeDelete: true);
            AddForeignKey("dbo.CambioEstadoes", "EstadoId", "dbo.Estadoes", "EstadoId", cascadeDelete: true);
        }
    }
}

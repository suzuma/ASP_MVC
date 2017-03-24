namespace PlantillaMVC_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnos",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, unicode: false),
                        sApellidos = c.String(nullable: false, unicode: false),
                        sGrupo = c.String(nullable: false, unicode: false),
                        sImagen = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AlumnoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alumnos");
        }
    }
}

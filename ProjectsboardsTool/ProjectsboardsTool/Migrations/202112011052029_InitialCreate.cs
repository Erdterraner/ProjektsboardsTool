namespace ProjectsboardsTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mitarbeiters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Vorname = c.String(),
                        Geburtsdatum = c.DateTime(nullable: false),
                        Position = c.String(),
                        Projekt = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Projekts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Projektleiter = c.Int(nullable: false),
                        StandinProzent = c.Int(nullable: false),
                        Budet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Projekts");
            DropTable("dbo.Mitarbeiters");
        }
    }
}

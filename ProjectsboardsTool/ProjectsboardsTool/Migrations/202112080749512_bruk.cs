namespace ProjectsboardsTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bruk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MitarbeiterProjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Project = c.Int(nullable: false),
                        Mitarbeiter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ZeitAufwand = c.DateTime(nullable: false),
                        Bearbeiter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TasksProjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Project = c.Int(nullable: false),
                        Task = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Projekts", "MitarbeiterProjekt", c => c.Int(nullable: false));
            AddColumn("dbo.Projekts", "TasksProject", c => c.Int(nullable: false));
            AlterColumn("dbo.Mitarbeiters", "Projekt", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mitarbeiters", "Projekt", c => c.String());
            DropColumn("dbo.Projekts", "TasksProject");
            DropColumn("dbo.Projekts", "MitarbeiterProjekt");
            DropTable("dbo.TasksProjects");
            DropTable("dbo.Tasks");
            DropTable("dbo.MitarbeiterProjects");
        }
    }
}

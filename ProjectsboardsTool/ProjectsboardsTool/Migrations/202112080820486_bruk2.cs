namespace ProjectsboardsTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bruk2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "ZeitAufwand", c => c.String());
            DropColumn("dbo.Mitarbeiters", "Projekt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mitarbeiters", "Projekt", c => c.Int());
            AlterColumn("dbo.Tasks", "ZeitAufwand", c => c.DateTime(nullable: false));
        }
    }
}

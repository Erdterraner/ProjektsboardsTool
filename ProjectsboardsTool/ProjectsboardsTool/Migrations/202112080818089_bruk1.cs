namespace ProjectsboardsTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bruk1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mitarbeiters", "Geburtsdatum", c => c.DateTime());
            AlterColumn("dbo.Mitarbeiters", "Projekt", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mitarbeiters", "Projekt", c => c.Int(nullable: false));
            AlterColumn("dbo.Mitarbeiters", "Geburtsdatum", c => c.DateTime(nullable: false));
        }
    }
}

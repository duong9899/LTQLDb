namespace LTQLDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Employees : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Email", c => c.String());
            AddColumn("dbo.People", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Discriminator");
            DropColumn("dbo.People", "Email");
        }
    }
}

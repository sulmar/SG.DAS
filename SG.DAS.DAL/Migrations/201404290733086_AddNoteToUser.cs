namespace SG.DAS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNoteToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Note");
        }
    }
}

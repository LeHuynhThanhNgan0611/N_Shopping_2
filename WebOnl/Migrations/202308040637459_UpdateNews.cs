namespace WebOnl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_News", "CreatedBy", c => c.String());
            AddColumn("dbo.tb_News", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_News", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_News", "Modifiedby", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_News", "Modifiedby");
            DropColumn("dbo.tb_News", "ModifiedDate");
            DropColumn("dbo.tb_News", "CreatedDate");
            DropColumn("dbo.tb_News", "CreatedBy");
        }
    }
}

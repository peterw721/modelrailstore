namespace _92031083_ModelRailStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_new_field : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PrefScale", c => c.String(nullable: false, maxLength: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PrefScale");
        }
    }
}

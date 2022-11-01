namespace _92031083_ModelRailStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_scale_params : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "PrefScale", c => c.String(nullable: false, maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "PrefScale", c => c.String(nullable: false, maxLength: 2));
        }
    }
}

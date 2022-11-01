namespace _92031083_ModelRailStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_user_fields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "address_AddressLine1", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "address_AddressLine2", c => c.String());
            AddColumn("dbo.AspNetUsers", "address_Town", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "address_Country", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "address_PostCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "address_PostCode");
            DropColumn("dbo.AspNetUsers", "address_Country");
            DropColumn("dbo.AspNetUsers", "address_Town");
            DropColumn("dbo.AspNetUsers", "address_AddressLine2");
            DropColumn("dbo.AspNetUsers", "address_AddressLine1");
            DropColumn("dbo.AspNetUsers", "DateOfBirth");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}

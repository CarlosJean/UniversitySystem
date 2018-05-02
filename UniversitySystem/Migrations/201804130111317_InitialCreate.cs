namespace UniversitySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Headquarters",
                c => new
                    {
                        HeadquartersId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.HeadquartersId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Headquarters");
        }
    }
}

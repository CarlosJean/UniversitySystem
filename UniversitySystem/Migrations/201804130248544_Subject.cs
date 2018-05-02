namespace UniversitySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Subject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Schedule = c.String(),
                    })
                .PrimaryKey(t => t.SubjectID);
            
            AlterColumn("dbo.Headquarters", "Name", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Headquarters", "Name", c => c.String());
            DropTable("dbo.Subjects");
        }
    }
}

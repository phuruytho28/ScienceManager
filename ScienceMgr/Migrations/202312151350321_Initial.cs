namespace ScienceMgr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Abstract = c.String(nullable: false, maxLength: 1000),
                        Keywords = c.String(nullable: false, maxLength: 500),
                        SubmissionDate = c.DateTime(nullable: false),
                        SubmisstionAt = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Gender = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                        BirthDate = c.DateTime(nullable: false),
                        Role = c.Int(nullable: false),
                        Address = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GraduationTopics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Topic = c.String(nullable: false, maxLength: 500),
                        Description = c.String(nullable: false, maxLength: 1000),
                        Grade = c.Single(nullable: false),
                        StudentId = c.Int(nullable: false),
                        SupervisorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .ForeignKey("dbo.Users", t => t.SupervisorId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.SupervisorId);
            
            CreateTable(
                "dbo.Researches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 500),
                        Keywords = c.String(nullable: false, maxLength: 500),
                        Description = c.String(nullable: false, maxLength: 1000),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserArticles",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Article_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Article_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Articles", t => t.Article_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Article_Id);
            
            CreateTable(
                "dbo.UserResearches",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Research_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Research_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Researches", t => t.Research_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Research_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserResearches", "Research_Id", "dbo.Researches");
            DropForeignKey("dbo.UserResearches", "User_Id", "dbo.Users");
            DropForeignKey("dbo.GraduationTopics", "SupervisorId", "dbo.Users");
            DropForeignKey("dbo.GraduationTopics", "Id", "dbo.Users");
            DropForeignKey("dbo.UserArticles", "Article_Id", "dbo.Articles");
            DropForeignKey("dbo.UserArticles", "User_Id", "dbo.Users");
            DropIndex("dbo.UserResearches", new[] { "Research_Id" });
            DropIndex("dbo.UserResearches", new[] { "User_Id" });
            DropIndex("dbo.UserArticles", new[] { "Article_Id" });
            DropIndex("dbo.UserArticles", new[] { "User_Id" });
            DropIndex("dbo.GraduationTopics", new[] { "SupervisorId" });
            DropIndex("dbo.GraduationTopics", new[] { "Id" });
            DropTable("dbo.UserResearches");
            DropTable("dbo.UserArticles");
            DropTable("dbo.Researches");
            DropTable("dbo.GraduationTopics");
            DropTable("dbo.Users");
            DropTable("dbo.Articles");
        }
    }
}

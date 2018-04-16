namespace AutomaticMigrationFalse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        DogumYili = c.DateTime(nullable: false),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .Index(t => t.Team_TeamId);
            
            CreateTable(
                "dbo.PlayerAddresses",
                c => new
                    {
                        PlayerAddressID = c.Int(nullable: false),
                        City = c.String(),
                        Street = c.String(),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.PlayerAddressID)
                .ForeignKey("dbo.Players", t => t.PlayerAddressID)
                .Index(t => t.PlayerAddressID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        KurulusYili = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        SponsorId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.SponsorId);
            
            CreateTable(
                "dbo.SponsorTeams",
                c => new
                    {
                        Sponsor_SponsorId = c.Int(nullable: false),
                        Team_TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sponsor_SponsorId, t.Team_TeamId })
                .ForeignKey("dbo.Sponsors", t => t.Sponsor_SponsorId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId, cascadeDelete: true)
                .Index(t => t.Sponsor_SponsorId)
                .Index(t => t.Team_TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SponsorTeams", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.SponsorTeams", "Sponsor_SponsorId", "dbo.Sponsors");
            DropForeignKey("dbo.Players", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.PlayerAddresses", "PlayerAddressID", "dbo.Players");
            DropIndex("dbo.SponsorTeams", new[] { "Team_TeamId" });
            DropIndex("dbo.SponsorTeams", new[] { "Sponsor_SponsorId" });
            DropIndex("dbo.PlayerAddresses", new[] { "PlayerAddressID" });
            DropIndex("dbo.Players", new[] { "Team_TeamId" });
            DropTable("dbo.SponsorTeams");
            DropTable("dbo.Sponsors");
            DropTable("dbo.Teams");
            DropTable("dbo.PlayerAddresses");
            DropTable("dbo.Players");
        }
    }
}

namespace ControleAtivosTI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Portfolio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Portifolios",
                c => new
                    {
                        IdPortefolio = c.Int(nullable: false, identity: true),
                        NomeSistema = c.String(),
                    })
                .PrimaryKey(t => t.IdPortefolio);
            
            CreateTable(
                "dbo.Unidades",
                c => new
                    {
                        IdUE = c.Int(nullable: false, identity: true),
                        NomeUE = c.String(),
                        INEP = c.Int(nullable: false),
                        CNPJ = c.Int(nullable: false),
                        NProtocolo = c.Int(nullable: false),
                        URG = c.String(),
                        Endereco = c.String(),
                        CEP = c.Int(nullable: false),
                        UETel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdUE);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Unidades");
            DropTable("dbo.Portifolios");
        }
    }
}

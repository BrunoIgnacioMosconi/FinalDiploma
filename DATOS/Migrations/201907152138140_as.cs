namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _as : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ITEM", "Observador", c => c.String());
            AddColumn("dbo.PRODUCTO", "cantStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PRODUCTO", "cantStock");
            DropColumn("dbo.ITEM", "Observador");
        }
    }
}

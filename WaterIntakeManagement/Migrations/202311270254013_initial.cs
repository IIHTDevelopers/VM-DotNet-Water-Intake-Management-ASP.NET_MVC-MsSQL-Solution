namespace WaterIntakeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WaterIntakes",
                c => new
                    {
                        WaterIntakeEntryId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        AmountInMilliliters = c.Int(nullable: false),
                        TimeOfDay = c.Time(nullable: false, precision: 7),
                        Notes = c.String(),
                        DailyGoalInMilliliters = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WaterIntakeEntryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WaterIntakes");
        }
    }
}

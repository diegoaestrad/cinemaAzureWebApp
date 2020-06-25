using Microsoft.EntityFrameworkCore.Migrations;

namespace cinemaAzureWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    CinemaId = table.Column<short>(type: "smallint", nullable: false).Annotation("SqlServer:Identity","1,1"),
                    CinemaName = table.Column<string>(type: "varchar(50)", nullable: false),
                    CinemaAddress = table.Column<string>(type: "varchar(50)", nullable: true),
                    CinemaScreens = table.Column<short>(type: "smallint", nullable: false),
                    AmenitiesId = table.Column<short>(type: "smallint", nullable: false).Annotation("SqlServer:Identity","1,1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.CinemaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cinema");
        }
    }
}

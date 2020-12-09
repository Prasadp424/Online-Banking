using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBank.Migrations
{
    public partial class benficiarymodelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Customer",
                table: "Benficiarys",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer",
                table: "Benficiarys");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBank.Migrations
{
    public partial class benficiary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benficiarys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payee_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payee_Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bnak_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benficiarys", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Benficiarys");
        }
    }
}

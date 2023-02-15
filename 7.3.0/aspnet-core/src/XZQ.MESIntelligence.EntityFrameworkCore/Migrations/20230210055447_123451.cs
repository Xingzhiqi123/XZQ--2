using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XZQ.MESIntelligence.Migrations
{
    public partial class _123451 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teamorgroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamorgroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamorgroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamorgroupGrouping = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamorgroupRemark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linenumbers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffBit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preparedby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Auditor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JinDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teamorgroup", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teamorgroup");
        }
    }
}

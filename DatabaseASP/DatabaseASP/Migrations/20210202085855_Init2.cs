using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseASP.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "gender", "release" },
                values: new object[] { "Film o databázích", "Vzdělávací", new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "gender", "release" },
                values: new object[] { "Miluju tě zlato", "romantic", new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}

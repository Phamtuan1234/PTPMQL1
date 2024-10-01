using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CanCuocCongDan",
                table: "Person",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    CanCuocCongDan = table.Column<string>(type: "TEXT", nullable: false),
                    ChucVu = table.Column<string>(type: "TEXT", nullable: false),
                    ThoiGianLamViec = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.CanCuocCongDan);
                    table.ForeignKey(
                        name: "FK_Employee_Person_CanCuocCongDan",
                        column: x => x.CanCuocCongDan,
                        principalTable: "Person",
                        principalColumn: "CanCuocCongDan",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "CanCuocCongDan",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}

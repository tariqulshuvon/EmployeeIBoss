using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblEmplyees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "502030, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeSalary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupervisorId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmplyees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "TblEmpAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeeId = table.Column<int>(type: "int", nullable: false),
                    TblEmplyeeEmployeeId = table.Column<int>(type: "int", nullable: true),
                    AttendanceDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsPreset = table.Column<bool>(type: "bit", nullable: false),
                    IsAbsent = table.Column<bool>(type: "bit", nullable: false),
                    IsOffday = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmpAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblEmpAttendances_TblEmplyees_TblEmplyeeEmployeeId",
                        column: x => x.TblEmplyeeEmployeeId,
                        principalTable: "TblEmplyees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpAttendances_TblEmplyeeEmployeeId",
                table: "TblEmpAttendances",
                column: "TblEmplyeeEmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblEmpAttendances");

            migrationBuilder.DropTable(
                name: "TblEmplyees");
        }
    }
}

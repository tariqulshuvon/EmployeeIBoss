using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Migrations
{
    /// <inheritdoc />
    public partial class JoinDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblEmpAttendances_TblEmplyees_TblEmplyeeEmployeeId",
                table: "TblEmpAttendances");

            migrationBuilder.DropIndex(
                name: "IX_TblEmpAttendances_TblEmplyeeEmployeeId",
                table: "TblEmpAttendances");

            migrationBuilder.DropColumn(
                name: "TblEmplyeeEmployeeId",
                table: "TblEmpAttendances");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TblEmplyeeEmployeeId",
                table: "TblEmpAttendances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpAttendances_TblEmplyeeEmployeeId",
                table: "TblEmpAttendances",
                column: "TblEmplyeeEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblEmpAttendances_TblEmplyees_TblEmplyeeEmployeeId",
                table: "TblEmpAttendances",
                column: "TblEmplyeeEmployeeId",
                principalTable: "TblEmplyees",
                principalColumn: "EmployeeId");
        }
    }
}

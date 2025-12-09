using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class precontrol2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId1",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Positions_PositionId1",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_MenteeDesiredSkills_Skills_SkillId1",
                table: "MenteeDesiredSkills");

            migrationBuilder.DropIndex(
                name: "IX_MenteeDesiredSkills_SkillId1",
                table: "MenteeDesiredSkills");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PositionId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SkillId1",
                table: "MenteeDesiredSkills");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PositionId1",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SkillId1",
                table: "MenteeDesiredSkills",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DepartmentId1",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PositionId1",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenteeDesiredSkills_SkillId1",
                table: "MenteeDesiredSkills",
                column: "SkillId1");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId1",
                table: "Employees",
                column: "DepartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId1",
                table: "Employees",
                column: "PositionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId1",
                table: "Employees",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Positions_PositionId1",
                table: "Employees",
                column: "PositionId1",
                principalTable: "Positions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenteeDesiredSkills_Skills_SkillId1",
                table: "MenteeDesiredSkills",
                column: "SkillId1",
                principalTable: "Skills",
                principalColumn: "Id");
        }
    }
}

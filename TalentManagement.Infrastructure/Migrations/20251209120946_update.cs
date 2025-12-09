using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SkillId",
                table: "MentorSpecializations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_MentorSpecializations_SkillId",
                table: "MentorSpecializations",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_MentorSpecializations_Skills_SkillId",
                table: "MentorSpecializations",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MentorSpecializations_Skills_SkillId",
                table: "MentorSpecializations");

            migrationBuilder.DropIndex(
                name: "IX_MentorSpecializations_SkillId",
                table: "MentorSpecializations");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "MentorSpecializations");
        }
    }
}

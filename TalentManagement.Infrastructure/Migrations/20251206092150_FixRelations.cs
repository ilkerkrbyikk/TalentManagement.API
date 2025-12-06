using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenteeProfiles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenteeProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MentorProfiles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    MaxMenteeCapacity = table.Column<int>(type: "int", nullable: false),
                    CurrentMenteeCount = table.Column<int>(type: "int", nullable: false),
                    IsAvailableForNewMentees = table.Column<bool>(type: "bit", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentorProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mentorships",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MentorshipGoal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeetingFrequency = table.Column<int>(type: "int", nullable: false),
                    RequestedAt = table.Column<DateOnly>(type: "date", nullable: false),
                    StartedAt = table.Column<DateOnly>(type: "date", nullable: true),
                    EndedAt = table.Column<DateOnly>(type: "date", nullable: true),
                    PlannedEndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CancellationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MentorProfileId = table.Column<long>(type: "bigint", nullable: false),
                    MenteeProfileId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentorships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mentorships_MenteeProfiles_MenteeProfileId",
                        column: x => x.MenteeProfileId,
                        principalTable: "MenteeProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mentorships_MentorProfiles_MentorProfileId",
                        column: x => x.MentorProfileId,
                        principalTable: "MentorProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MentorSpecializations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MentorId = table.Column<long>(type: "bigint", nullable: false),
                    ProficiencyLevel = table.Column<int>(type: "int", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentorSpecializations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MentorSpecializations_MentorProfiles_MentorId",
                        column: x => x.MentorId,
                        principalTable: "MentorProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProfiles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerId = table.Column<long>(type: "bigint", nullable: true),
                    MentorProfileId = table.Column<long>(type: "bigint", nullable: true),
                    MenteeProfileId = table.Column<long>(type: "bigint", nullable: true),
                    PositionId = table.Column<long>(type: "bigint", nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeProfiles_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProfiles_EmployeeProfiles_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "EmployeeProfiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeProfiles_MenteeProfiles_MenteeProfileId",
                        column: x => x.MenteeProfileId,
                        principalTable: "MenteeProfiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeProfiles_MentorProfiles_MentorProfileId",
                        column: x => x.MentorProfileId,
                        principalTable: "MentorProfiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeProfiles_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenteeDesiredSkills",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenteeProfileId = table.Column<long>(type: "bigint", nullable: false),
                    SkillId = table.Column<long>(type: "bigint", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenteeDesiredSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenteeDesiredSkills_MenteeProfiles_MenteeProfileId",
                        column: x => x.MenteeProfileId,
                        principalTable: "MenteeProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenteeDesiredSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeHobbies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    HobbyId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeHobbies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeHobbies_EmployeeProfiles_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EmployeeProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeHobbies_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHobbies_EmployeeId",
                table: "EmployeeHobbies",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHobbies_HobbyId",
                table: "EmployeeHobbies",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfiles_DepartmentId",
                table: "EmployeeProfiles",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfiles_ManagerId",
                table: "EmployeeProfiles",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfiles_MenteeProfileId",
                table: "EmployeeProfiles",
                column: "MenteeProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfiles_MentorProfileId",
                table: "EmployeeProfiles",
                column: "MentorProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfiles_PositionId",
                table: "EmployeeProfiles",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_MenteeDesiredSkills_MenteeProfileId",
                table: "MenteeDesiredSkills",
                column: "MenteeProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_MenteeDesiredSkills_SkillId",
                table: "MenteeDesiredSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Mentorships_MenteeProfileId",
                table: "Mentorships",
                column: "MenteeProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Mentorships_MentorProfileId",
                table: "Mentorships",
                column: "MentorProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_MentorSpecializations_MentorId",
                table: "MentorSpecializations",
                column: "MentorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeHobbies");

            migrationBuilder.DropTable(
                name: "MenteeDesiredSkills");

            migrationBuilder.DropTable(
                name: "Mentorships");

            migrationBuilder.DropTable(
                name: "MentorSpecializations");

            migrationBuilder.DropTable(
                name: "EmployeeProfiles");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "MenteeProfiles");

            migrationBuilder.DropTable(
                name: "MentorProfiles");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}

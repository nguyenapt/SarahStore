using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sarah.Store.Migrations
{
    /// <inheritdoc />
    public partial class add_course_subject_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppSubjects");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppSubjects");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppSubjects");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppSubjects");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppSubjects");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppSubjects");

            migrationBuilder.CreateTable(
                name: "AppCourses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCourses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppCourses");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppSubjects",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppSubjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppSubjects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppSubjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppSubjects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppSubjects",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}

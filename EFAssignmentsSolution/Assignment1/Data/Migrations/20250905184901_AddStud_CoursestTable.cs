using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddStud_CoursestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stud_Courses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Courses", x => new { x.StudentId, x.CourseId });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stud_Courses");
        }
    }
}

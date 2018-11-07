using Microsoft.EntityFrameworkCore.Migrations;

namespace A2.Migrations
{
    public partial class A2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    LoginName = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.LoginName);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    EmpID = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Course = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Department = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.EmpID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Program = table.Column<string>(unicode: false, maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentID = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    StudentID = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    EmpID = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Details = table.Column<string>(unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comment_Staff",
                        column: x => x.EmpID,
                        principalTable: "Staff",
                        principalColumn: "EmpID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Student",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseCode = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    StudentID = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    StaffID = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    CourseTitle = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Course_Staff",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "EmpID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Course_Student",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    RatingID = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    StudentID = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Comment = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.RatingID);
                    table.ForeignKey(
                        name: "FK_Rating_Student",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_EmpID",
                table: "Comment",
                column: "EmpID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_StudentID",
                table: "Comment",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_StaffID",
                table: "Course",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_StudentID",
                table: "Course",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_StudentID",
                table: "Rating",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}

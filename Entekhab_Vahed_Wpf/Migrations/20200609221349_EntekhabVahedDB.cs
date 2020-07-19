using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entekhab_Vahed_Wpf.Migrations
{
    public partial class EntekhabVahedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    FieldId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.FieldId);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    pCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    field_id = table.Column<int>(nullable: false),
                    FieldId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.pCode);
                    table.ForeignKey(
                        name: "FK_Professor_Field_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Field",
                        principalColumn: "FieldId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    sCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    NatCode = table.Column<int>(nullable: false),
                    Degree = table.Column<string>(nullable: true),
                    field_id = table.Column<int>(nullable: false),
                    FieldId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.sCode);
                    table.ForeignKey(
                        name: "FK_Student_Field_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Field",
                        principalColumn: "FieldId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    lCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Vahed = table.Column<int>(nullable: false),
                    field_id = table.Column<int>(nullable: false),
                    prof_id = table.Column<int>(nullable: false),
                    FieldId = table.Column<int>(nullable: true),
                    ProfessorpCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.lCode);
                    table.ForeignKey(
                        name: "FK_Lesson_Field_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Field",
                        principalColumn: "FieldId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_Professor_ProfessorpCode",
                        column: x => x.ProfessorpCode,
                        principalTable: "Professor",
                        principalColumn: "pCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChooseUnit",
                columns: table => new
                {
                    CUCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lesson_code = table.Column<int>(nullable: false),
                    prof_id = table.Column<int>(nullable: false),
                    stud_id = table.Column<int>(nullable: false),
                    field_id = table.Column<int>(nullable: false),
                    cUnit = table.Column<int>(nullable: false),
                    FieldId = table.Column<int>(nullable: true),
                    LessonlCode = table.Column<int>(nullable: true),
                    ProfessorpCode = table.Column<int>(nullable: true),
                    StudentsCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChooseUnit", x => x.CUCode);
                    table.ForeignKey(
                        name: "FK_ChooseUnit_Field_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Field",
                        principalColumn: "FieldId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChooseUnit_Lesson_LessonlCode",
                        column: x => x.LessonlCode,
                        principalTable: "Lesson",
                        principalColumn: "lCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChooseUnit_Professor_ProfessorpCode",
                        column: x => x.ProfessorpCode,
                        principalTable: "Professor",
                        principalColumn: "pCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChooseUnit_Student_StudentsCode",
                        column: x => x.StudentsCode,
                        principalTable: "Student",
                        principalColumn: "sCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    classCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true),
                    Dates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lesson_code = table.Column<int>(nullable: false),
                    prof_id = table.Column<int>(nullable: false),
                    Times = table.Column<TimeSpan>(nullable: false),
                    Makan = table.Column<string>(nullable: true),
                    capacity = table.Column<int>(nullable: false),
                    LessonlCode = table.Column<int>(nullable: true),
                    ProfessorpCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.classCode);
                    table.ForeignKey(
                        name: "FK_Classes_Lesson_LessonlCode",
                        column: x => x.LessonlCode,
                        principalTable: "Lesson",
                        principalColumn: "lCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_Professor_ProfessorpCode",
                        column: x => x.ProfessorpCode,
                        principalTable: "Professor",
                        principalColumn: "pCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    scCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prof_id = table.Column<int>(nullable: false),
                    lesson_code = table.Column<int>(nullable: false),
                    stud_id = table.Column<int>(nullable: false),
                    score = table.Column<int>(nullable: false),
                    cUnit = table.Column<int>(nullable: false),
                    LessonlCode = table.Column<int>(nullable: true),
                    ProfessorpCode = table.Column<int>(nullable: true),
                    StudentsCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.scCode);
                    table.ForeignKey(
                        name: "FK_Scores_Lesson_LessonlCode",
                        column: x => x.LessonlCode,
                        principalTable: "Lesson",
                        principalColumn: "lCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scores_Professor_ProfessorpCode",
                        column: x => x.ProfessorpCode,
                        principalTable: "Professor",
                        principalColumn: "pCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scores_Student_StudentsCode",
                        column: x => x.StudentsCode,
                        principalTable: "Student",
                        principalColumn: "sCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChooseUnit_FieldId",
                table: "ChooseUnit",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_ChooseUnit_LessonlCode",
                table: "ChooseUnit",
                column: "LessonlCode");

            migrationBuilder.CreateIndex(
                name: "IX_ChooseUnit_ProfessorpCode",
                table: "ChooseUnit",
                column: "ProfessorpCode");

            migrationBuilder.CreateIndex(
                name: "IX_ChooseUnit_StudentsCode",
                table: "ChooseUnit",
                column: "StudentsCode");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_LessonlCode",
                table: "Classes",
                column: "LessonlCode");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ProfessorpCode",
                table: "Classes",
                column: "ProfessorpCode");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_FieldId",
                table: "Lesson",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ProfessorpCode",
                table: "Lesson",
                column: "ProfessorpCode");

            migrationBuilder.CreateIndex(
                name: "IX_Professor_FieldId",
                table: "Professor",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_LessonlCode",
                table: "Scores",
                column: "LessonlCode");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_ProfessorpCode",
                table: "Scores",
                column: "ProfessorpCode");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_StudentsCode",
                table: "Scores",
                column: "StudentsCode");

            migrationBuilder.CreateIndex(
                name: "IX_Student_FieldId",
                table: "Student",
                column: "FieldId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChooseUnit");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Field");
        }
    }
}

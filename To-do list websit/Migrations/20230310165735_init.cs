using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_do_list_websit.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskDto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    states = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDto", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tasks",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    states = table.Column<int>(type: "int", nullable: false),
                    Userid = table.Column<int>(type: "int", nullable: true),
                    Categoryid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tasks", x => x.id);
                    table.ForeignKey(
                        name: "FK_tasks_TaskCategory_Categoryid",
                        column: x => x.Categoryid,
                        principalTable: "TaskCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tasks_user_Userid",
                        column: x => x.Userid,
                        principalTable: "user",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tasks_Categoryid",
                table: "tasks",
                column: "Categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_tasks_Userid",
                table: "tasks",
                column: "Userid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskDto");

            migrationBuilder.DropTable(
                name: "tasks");

            migrationBuilder.DropTable(
                name: "TaskCategory");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}

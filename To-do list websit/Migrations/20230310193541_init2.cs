using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_do_list_websit.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tasks_TaskCategory_Categoryid",
                table: "tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_tasks_user_Userid",
                table: "tasks");

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_TaskCategory_Categoryid",
                table: "tasks",
                column: "Categoryid",
                principalTable: "TaskCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_user_Userid",
                table: "tasks",
                column: "Userid",
                principalTable: "user",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tasks_TaskCategory_Categoryid",
                table: "tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_tasks_user_Userid",
                table: "tasks");

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_TaskCategory_Categoryid",
                table: "tasks",
                column: "Categoryid",
                principalTable: "TaskCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_user_Userid",
                table: "tasks",
                column: "Userid",
                principalTable: "user",
                principalColumn: "ID");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Tasker.Migrations
{
    public partial class UpdatedFinishedColumnToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Finshed",
                table: "Task",
                newName: "Finished");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Finished",
                table: "Task",
                newName: "Finshed");
        }
    }
}

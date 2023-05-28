using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Workshop.Migrations
{
    /// <inheritdoc />
    public partial class addfacultyinfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_class_infos",
                table: "class_infos");

            migrationBuilder.RenameTable(
                name: "class_infos",
                newName: "class_info");

            migrationBuilder.AddPrimaryKey(
                name: "pk_class_info",
                table: "class_info",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_class_info",
                table: "class_info");

            migrationBuilder.RenameTable(
                name: "class_info",
                newName: "class_infos");

            migrationBuilder.AddPrimaryKey(
                name: "pk_class_infos",
                table: "class_infos",
                column: "id");
        }
    }
}

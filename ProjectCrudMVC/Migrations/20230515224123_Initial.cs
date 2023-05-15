using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCrudMVC.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CódigoDoProduto",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "Ean",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ean",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "CódigoDoProduto",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

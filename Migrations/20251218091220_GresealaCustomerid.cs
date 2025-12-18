using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Porumb_Denisa_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class GresealaCustomerid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CusstomerID",
                table: "Order");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CusstomerID",
                table: "Order",
                type: "int",
                nullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WasmBlazorAppAssignment.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleSaleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classification = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    MSRP = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleSaleDetails", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "VehicleSaleDetails",
                columns: new[] { "Id", "Classification", "Colour", "Cost", "MSRP", "Make", "Model" },
                values: new object[,]
                {
                    { 1, 0, "Red", 1500.0, 3000.0, "Audi", "A4" },
                    { 2, 1, "Blue", 4000.0, 9000.0, "Chevrolet", "Camaro" },
                    { 3, 2, "Red", 5000.0, 12000.0, "Dodge", "Ram" },
                    { 4, 2, "Black", 1500.0, 3000.0, "Audi", "A4" },
                    { 5, 0, "Blue", 40000.0, 50000.0, "Chevrolet", "Camaro" },
                    { 6, 0, "Red", 5000.0, 12000.0, "Dodge", "Ram" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleSaleDetails");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleRentalData.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnginePower = table.Column<int>(type: "int", nullable: false),
                    TransportCapacity = table.Column<int>(type: "int", nullable: false),
                    RequiredDriverLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelConsumption = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnginePower = table.Column<int>(type: "int", nullable: false),
                    TransportCapacity = table.Column<int>(type: "int", nullable: false),
                    RequiredDriverLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelConsumption = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    HasTrailer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Trucks");
        }
    }
}

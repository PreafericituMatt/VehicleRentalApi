using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleRentalData.Migrations
{
    /// <inheritdoc />
    public partial class FuelReport1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FuelConsumptionReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    VehicleCar = table.Column<bool>(type: "bit", nullable: false),
                    VehicleTruck = table.Column<bool>(type: "bit", nullable: false),
                    CurrentMileage = table.Column<int>(type: "int", nullable: false),
                    LitersOfFuelConsumed = table.Column<int>(type: "int", nullable: false),
                    DaysRented = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelConsumptionReports", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FuelConsumptionReports");
        }
    }
}

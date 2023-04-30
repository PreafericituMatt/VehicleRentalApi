using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleRentalData.Migrations
{
    /// <inheritdoc />
    public partial class helpmepls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleTruck",
                table: "FuelConsumptionReports");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "VehicleTruck",
                table: "FuelConsumptionReports",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

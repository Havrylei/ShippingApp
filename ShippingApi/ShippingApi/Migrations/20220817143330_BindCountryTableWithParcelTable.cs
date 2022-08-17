using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingApi.Migrations
{
    public partial class BindCountryTableWithParcelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Parcels_DestinationCountry",
                table: "Parcels",
                column: "DestinationCountry");

            migrationBuilder.AddForeignKey(
                name: "FK_Parcels_Countries_DestinationCountry",
                table: "Parcels",
                column: "DestinationCountry",
                principalTable: "Countries",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parcels_Countries_DestinationCountry",
                table: "Parcels");

            migrationBuilder.DropIndex(
                name: "IX_Parcels_DestinationCountry",
                table: "Parcels");
        }
    }
}

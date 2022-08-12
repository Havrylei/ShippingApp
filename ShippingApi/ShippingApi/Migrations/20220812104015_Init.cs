using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingApi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentNumber = table.Column<string>(type: "nchar(10)", nullable: false),
                    Airport = table.Column<int>(type: "int", nullable: false),
                    FlightNumber = table.Column<string>(type: "nchar(6)", nullable: false),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BagNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ShipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountOfLetters = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(8,3)", precision: 8, scale: 3, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bags_Shipments_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParcelNumber = table.Column<string>(type: "nchar(10)", nullable: false),
                    RecipientName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DestinationCountry = table.Column<string>(type: "nchar(2)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(8,3)", precision: 8, scale: 3, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    ParcelBagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parcels_Bags_ParcelBagId",
                        column: x => x.ParcelBagId,
                        principalTable: "Bags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bags_BagNumber",
                table: "Bags",
                column: "BagNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bags_ShipmentId",
                table: "Bags",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_ParcelBagId",
                table: "Parcels",
                column: "ParcelBagId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_ParcelNumber",
                table: "Parcels",
                column: "ParcelNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_ShipmentNumber",
                table: "Shipments",
                column: "ShipmentNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DropTable(
                name: "Bags");

            migrationBuilder.DropTable(
                name: "Shipments");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication11.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<long>(nullable: false),
                    CarNumber = table.Column<string>(nullable: true),
                    CarType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    From = table.Column<double>(nullable: false),
                    To = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClientId = table.Column<Guid>(nullable: true),
                    DriverId = table.Column<Guid>(nullable: true),
                    State = table.Column<int>(nullable: false),
                    Tarif = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    FromId = table.Column<Guid>(nullable: true),
                    ToId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Location_FromId",
                        column: x => x.FromId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Location_ToId",
                        column: x => x.ToId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("42ad1390-d115-4906-8215-0a937d5028e7"), "Фархад", 87771234565L },
                    { new Guid("8eeb657d-a804-4293-a64c-03a58ea8a597"), "Филип", 87771234565L }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "CarNumber", "CarType", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("32ec2112-37c4-4f7e-b264-9c9e7fe445f8"), "13/ABZ/745", "Lada2112", "Рашид", 87756544828L },
                    { new Guid("a957b6e0-bbc8-42fb-bcfd-2b2384a80145"), "13/RUS/228", "Lada Kalina", "Рафик", 87756544828L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DriverId",
                table: "Orders",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FromId",
                table: "Orders",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ToId",
                table: "Orders",
                column: "ToId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}

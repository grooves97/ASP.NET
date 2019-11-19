using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication11.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Location_FromId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Location_ToId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Orders_FromId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ToId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("42ad1390-d115-4906-8215-0a937d5028e7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8eeb657d-a804-4293-a64c-03a58ea8a597"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("32ec2112-37c4-4f7e-b264-9c9e7fe445f8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a957b6e0-bbc8-42fb-bcfd-2b2384a80145"));

            migrationBuilder.DropColumn(
                name: "FromId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ToId",
                table: "Orders");

            migrationBuilder.AddColumn<double>(
                name: "LocationFrom",
                table: "Orders",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LocationTo",
                table: "Orders",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("b1964645-7ec9-4d9d-b310-26c308789a4a"), "Фархад", 87771234565L },
                    { new Guid("a67540b1-c874-4690-9844-43b77597ef3c"), "Филип", 87771234565L }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "CarNumber", "CarType", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("a621b737-fbf0-4822-bd67-31f4021fc80a"), "13/ABZ/745", "Lada2112", "Рашид", 87756544828L },
                    { new Guid("a1a5ea30-f34e-4e1b-8f7f-b38088aebcc7"), "13/RUS/228", "Lada Kalina", "Рафик", 87756544828L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a67540b1-c874-4690-9844-43b77597ef3c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b1964645-7ec9-4d9d-b310-26c308789a4a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a1a5ea30-f34e-4e1b-8f7f-b38088aebcc7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a621b737-fbf0-4822-bd67-31f4021fc80a"));

            migrationBuilder.DropColumn(
                name: "LocationFrom",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LocationTo",
                table: "Orders");

            migrationBuilder.AddColumn<Guid>(
                name: "FromId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ToId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    From = table.Column<double>(type: "float", nullable: false),
                    To = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
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
                name: "IX_Orders_FromId",
                table: "Orders",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ToId",
                table: "Orders",
                column: "ToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Location_FromId",
                table: "Orders",
                column: "FromId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Location_ToId",
                table: "Orders",
                column: "ToId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

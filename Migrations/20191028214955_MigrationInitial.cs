using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppRestaurant.Migrations
{
    public partial class MigrationInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "restaurant",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    number = table.Column<int>(nullable: false),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurant", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "restaurantConsumption",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(nullable: false),
                    value = table.Column<double>(nullable: false),
                    restaurantid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurantConsumption", x => x.id);
                    table.ForeignKey(
                        name: "FK_restaurantConsumption_restaurant_restaurantid",
                        column: x => x.restaurantid,
                        principalTable: "restaurant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_restaurantConsumption_restaurantid",
                table: "restaurantConsumption",
                column: "restaurantid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "restaurantConsumption");

            migrationBuilder.DropTable(
                name: "restaurant");
        }
    }
}

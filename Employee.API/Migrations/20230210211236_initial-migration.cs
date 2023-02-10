using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.API.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coffees",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coffees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "Id", "Description", "Name", "Price", "Rating", "Type" },
                values: new object[,]
                {
                    { "5c35a3a2-fa6e-4c17-b8ef-d63493318e8b", "A strong, concentrated coffee beverage made by forcing pressurized hot water through finely ground coffee beans.", "Espresso", 300.0, 4, null },
                    { "4575c2ab-e8d9-4fd8-a376-3d84a03ecca1", " A coffee beverage made with espresso and steamed milk, topped with a small amount of foam. ", "Latte", 550.0, 5, null },
                    { "2f5e6bb7-dff6-41c7-a8b9-708a83372f37", "A coffee drink made with equal parts espresso, steamed milk and milk foam.", "Cappuccino", 450.0, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "f24f97b2-bbc2-46cc-9e35-c65776f4c9af", 50, "David", "Mike" },
                    { "0ef0353f-d04a-44ac-8d8e-4f5d008d88a0", 50, "Steve", "Warner" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coffees");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

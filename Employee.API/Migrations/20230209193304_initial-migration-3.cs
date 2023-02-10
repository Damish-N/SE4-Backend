using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.API.Migrations
{
    public partial class initialmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "01523855-c94f-469e-ae25-70ba4274b817");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "422589b7-889c-4237-beec-39fcdd9548f1");

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

            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "Id", "Description", "Name", "Price", "Rating", "Type" },
                values: new object[,]
                {
                    { "0741053d-9604-4add-a92b-94268e8eb5f9", "A strong, concentrated coffee beverage made by forcing pressurized hot water through finely ground coffee beans.", "Espresso", 300.0, 4, null },
                    { "fd83c36b-d7be-4b9e-b073-4c321f799dd2", " A coffee beverage made with espresso and steamed milk, topped with a small amount of foam. ", "Latte", 550.0, 5, null },
                    { "f7716028-db41-47fc-9734-bff34e6ac94b", "A coffee drink made with equal parts espresso, steamed milk and milk foam.", "Cappuccino", 450.0, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "53227acf-81e8-4684-bcf8-0e19f47e1565", 50, "David", "Mike" },
                    { "2ee0c2a3-5f98-4496-88e3-ffd1c596aeb1", 50, "Steve", "Warner" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coffees");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2ee0c2a3-5f98-4496-88e3-ffd1c596aeb1");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "53227acf-81e8-4684-bcf8-0e19f47e1565");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { "01523855-c94f-469e-ae25-70ba4274b817", 50, "David", "Mike" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { "422589b7-889c-4237-beec-39fcdd9548f1", 50, "Steve", "Warner" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Warehouse.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsCompleted", "ProductName", "Quantity" },
                values: new object[] { 1, false, "ProductExample1", 10 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsCompleted", "ProductName", "Quantity" },
                values: new object[] { 2, false, "ProductExample2", 20 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsCompleted", "ProductName", "Quantity" },
                values: new object[] { 3, false, "ProductExample3", 30 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsCompleted", "ProductName", "Quantity" },
                values: new object[] { 4, false, "ProductExample4", 40 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsCompleted", "ProductName", "Quantity" },
                values: new object[] { 5, false, "ProductExample5", 50 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsCompleted", "ProductName", "Quantity" },
                values: new object[] { 6, false, "ProductExample6", 60 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsCompleted", "ProductName", "Quantity" },
                values: new object[] { 7, false, "ProductExample7", 70 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsCompleted", "ProductName", "Quantity" },
                values: new object[] { 8, false, "ProductExample8", 80 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsCompleted", "ProductName", "Quantity" },
                values: new object[] { 9, false, "ProductExample9", 90 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsCompleted", "ProductName", "Quantity" },
                values: new object[] { 10, false, "ProductExample10", 100 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsCompleted", "ProductName", "Quantity" },
                values: new object[] { 11, false, "ProductExample11", 110 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}

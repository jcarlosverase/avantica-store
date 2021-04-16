using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Infrastructure.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 535m, 6 },
                    { 73, "Description for product 73", "Product 73", 174m, 21 },
                    { 72, "Description for product 72", "Product 72", 336m, 57 },
                    { 71, "Description for product 71", "Product 71", 336m, 25 },
                    { 70, "Description for product 70", "Product 70", 654m, 51 },
                    { 69, "Description for product 69", "Product 69", 770m, 34 },
                    { 68, "Description for product 68", "Product 68", 320m, 90 },
                    { 67, "Description for product 67", "Product 67", 154m, 12 },
                    { 66, "Description for product 66", "Product 66", 924m, 3 },
                    { 65, "Description for product 65", "Product 65", 676m, 79 },
                    { 64, "Description for product 64", "Product 64", 399m, 43 },
                    { 63, "Description for product 63", "Product 63", 968m, 37 },
                    { 62, "Description for product 62", "Product 62", 740m, 10 },
                    { 61, "Description for product 61", "Product 61", 819m, 74 },
                    { 60, "Description for product 60", "Product 60", 672m, 68 },
                    { 59, "Description for product 59", "Product 59", 422m, 83 },
                    { 58, "Description for product 58", "Product 58", 186m, 78 },
                    { 57, "Description for product 57", "Product 57", 221m, 61 },
                    { 56, "Description for product 56", "Product 56", 582m, 13 },
                    { 55, "Description for product 55", "Product 55", 453m, 0 },
                    { 54, "Description for product 54", "Product 54", 512m, 84 },
                    { 53, "Description for product 53", "Product 53", 178m, 86 },
                    { 74, "Description for product 74", "Product 74", 120m, 63 },
                    { 52, "Description for product 52", "Product 52", 378m, 26 },
                    { 75, "Description for product 75", "Product 75", 192m, 91 },
                    { 77, "Description for product 77", "Product 77", 987m, 78 },
                    { 98, "Description for product 98", "Product 98", 981m, 24 },
                    { 97, "Description for product 97", "Product 97", 142m, 90 },
                    { 96, "Description for product 96", "Product 96", 462m, 53 },
                    { 95, "Description for product 95", "Product 95", 287m, 73 },
                    { 94, "Description for product 94", "Product 94", 140m, 27 },
                    { 93, "Description for product 93", "Product 93", 199m, 30 },
                    { 92, "Description for product 92", "Product 92", 403m, 72 },
                    { 91, "Description for product 91", "Product 91", 416m, 69 },
                    { 90, "Description for product 90", "Product 90", 118m, 74 },
                    { 89, "Description for product 89", "Product 89", 538m, 13 },
                    { 88, "Description for product 88", "Product 88", 476m, 54 },
                    { 87, "Description for product 87", "Product 87", 295m, 11 },
                    { 86, "Description for product 86", "Product 86", 136m, 1 },
                    { 85, "Description for product 85", "Product 85", 433m, 19 },
                    { 84, "Description for product 84", "Product 84", 166m, 1 },
                    { 83, "Description for product 83", "Product 83", 180m, 50 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 82, "Description for product 82", "Product 82", 288m, 59 },
                    { 81, "Description for product 81", "Product 81", 583m, 1 },
                    { 80, "Description for product 80", "Product 80", 371m, 71 },
                    { 79, "Description for product 79", "Product 79", 549m, 20 },
                    { 78, "Description for product 78", "Product 78", 922m, 50 },
                    { 76, "Description for product 76", "Product 76", 715m, 60 },
                    { 51, "Description for product 51", "Product 51", 332m, 21 },
                    { 50, "Description for product 50", "Product 50", 523m, 71 },
                    { 49, "Description for product 49", "Product 49", 497m, 62 },
                    { 22, "Description for product 22", "Product 22", 678m, 87 },
                    { 21, "Description for product 21", "Product 21", 114m, 97 },
                    { 20, "Description for product 20", "Product 20", 467m, 54 },
                    { 19, "Description for product 19", "Product 19", 215m, 37 },
                    { 18, "Description for product 18", "Product 18", 826m, 1 },
                    { 17, "Description for product 17", "Product 17", 896m, 94 },
                    { 16, "Description for product 16", "Product 16", 835m, 29 },
                    { 15, "Description for product 15", "Product 15", 391m, 84 },
                    { 14, "Description for product 14", "Product 14", 178m, 19 },
                    { 13, "Description for product 13", "Product 13", 250m, 61 },
                    { 12, "Description for product 12", "Product 12", 462m, 44 },
                    { 11, "Description for product 11", "Product 11", 402m, 29 },
                    { 10, "Description for product 10", "Product 10", 903m, 85 },
                    { 9, "Description for product 9", "Product 9", 960m, 4 },
                    { 8, "Description for product 8", "Product 8", 398m, 66 },
                    { 7, "Description for product 7", "Product 7", 315m, 52 },
                    { 6, "Description for product 6", "Product 6", 280m, 29 },
                    { 5, "Description for product 5", "Product 5", 875m, 21 },
                    { 4, "Description for product 4", "Product 4", 251m, 86 },
                    { 3, "Description for product 3", "Product 3", 844m, 92 },
                    { 2, "Description for product 2", "Product 2", 477m, 28 },
                    { 23, "Description for product 23", "Product 23", 653m, 66 },
                    { 24, "Description for product 24", "Product 24", 554m, 3 },
                    { 25, "Description for product 25", "Product 25", 622m, 61 },
                    { 26, "Description for product 26", "Product 26", 508m, 9 },
                    { 48, "Description for product 48", "Product 48", 735m, 4 },
                    { 47, "Description for product 47", "Product 47", 326m, 19 },
                    { 46, "Description for product 46", "Product 46", 415m, 15 },
                    { 45, "Description for product 45", "Product 45", 624m, 61 },
                    { 44, "Description for product 44", "Product 44", 192m, 65 },
                    { 43, "Description for product 43", "Product 43", 447m, 72 },
                    { 42, "Description for product 42", "Product 42", 652m, 70 },
                    { 41, "Description for product 41", "Product 41", 201m, 5 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 40, "Description for product 40", "Product 40", 851m, 50 },
                    { 39, "Description for product 39", "Product 39", 687m, 53 },
                    { 99, "Description for product 99", "Product 99", 138m, 66 },
                    { 38, "Description for product 38", "Product 38", 853m, 35 },
                    { 36, "Description for product 36", "Product 36", 579m, 58 },
                    { 35, "Description for product 35", "Product 35", 750m, 31 },
                    { 34, "Description for product 34", "Product 34", 464m, 29 },
                    { 33, "Description for product 33", "Product 33", 461m, 90 },
                    { 32, "Description for product 32", "Product 32", 583m, 2 },
                    { 31, "Description for product 31", "Product 31", 856m, 97 },
                    { 30, "Description for product 30", "Product 30", 208m, 20 },
                    { 29, "Description for product 29", "Product 29", 699m, 97 },
                    { 28, "Description for product 28", "Product 28", 426m, 18 },
                    { 27, "Description for product 27", "Product 27", 276m, 23 },
                    { 37, "Description for product 37", "Product 37", 674m, 34 },
                    { 100, "Description for product 100", "Product 100", 538m, 57 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Initialize : Migration
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
                    { 1, "Description for product 1", "Product 1", 776m, 41 },
                    { 73, "Description for product 73", "Product 73", 162m, 61 },
                    { 72, "Description for product 72", "Product 72", 819m, 92 },
                    { 71, "Description for product 71", "Product 71", 768m, 81 },
                    { 70, "Description for product 70", "Product 70", 867m, 49 },
                    { 69, "Description for product 69", "Product 69", 399m, 80 },
                    { 68, "Description for product 68", "Product 68", 687m, 47 },
                    { 67, "Description for product 67", "Product 67", 640m, 74 },
                    { 66, "Description for product 66", "Product 66", 311m, 80 },
                    { 65, "Description for product 65", "Product 65", 598m, 28 },
                    { 64, "Description for product 64", "Product 64", 979m, 56 },
                    { 63, "Description for product 63", "Product 63", 440m, 51 },
                    { 62, "Description for product 62", "Product 62", 520m, 97 },
                    { 61, "Description for product 61", "Product 61", 674m, 76 },
                    { 60, "Description for product 60", "Product 60", 478m, 57 },
                    { 59, "Description for product 59", "Product 59", 180m, 46 },
                    { 58, "Description for product 58", "Product 58", 360m, 52 },
                    { 57, "Description for product 57", "Product 57", 940m, 84 },
                    { 56, "Description for product 56", "Product 56", 565m, 2 },
                    { 55, "Description for product 55", "Product 55", 146m, 37 },
                    { 54, "Description for product 54", "Product 54", 167m, 13 },
                    { 53, "Description for product 53", "Product 53", 881m, 20 },
                    { 74, "Description for product 74", "Product 74", 557m, 67 },
                    { 52, "Description for product 52", "Product 52", 934m, 74 },
                    { 75, "Description for product 75", "Product 75", 901m, 42 },
                    { 77, "Description for product 77", "Product 77", 774m, 2 },
                    { 98, "Description for product 98", "Product 98", 336m, 23 },
                    { 97, "Description for product 97", "Product 97", 488m, 49 },
                    { 96, "Description for product 96", "Product 96", 185m, 38 },
                    { 95, "Description for product 95", "Product 95", 454m, 83 },
                    { 94, "Description for product 94", "Product 94", 149m, 57 },
                    { 93, "Description for product 93", "Product 93", 409m, 28 },
                    { 92, "Description for product 92", "Product 92", 710m, 12 },
                    { 91, "Description for product 91", "Product 91", 104m, 30 },
                    { 90, "Description for product 90", "Product 90", 917m, 76 },
                    { 89, "Description for product 89", "Product 89", 968m, 53 },
                    { 88, "Description for product 88", "Product 88", 850m, 82 },
                    { 87, "Description for product 87", "Product 87", 655m, 93 },
                    { 86, "Description for product 86", "Product 86", 269m, 28 },
                    { 85, "Description for product 85", "Product 85", 269m, 81 },
                    { 84, "Description for product 84", "Product 84", 482m, 18 },
                    { 83, "Description for product 83", "Product 83", 224m, 71 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 82, "Description for product 82", "Product 82", 623m, 76 },
                    { 81, "Description for product 81", "Product 81", 304m, 50 },
                    { 80, "Description for product 80", "Product 80", 433m, 35 },
                    { 79, "Description for product 79", "Product 79", 442m, 94 },
                    { 78, "Description for product 78", "Product 78", 417m, 82 },
                    { 76, "Description for product 76", "Product 76", 945m, 95 },
                    { 51, "Description for product 51", "Product 51", 627m, 84 },
                    { 50, "Description for product 50", "Product 50", 639m, 99 },
                    { 49, "Description for product 49", "Product 49", 481m, 16 },
                    { 22, "Description for product 22", "Product 22", 356m, 99 },
                    { 21, "Description for product 21", "Product 21", 700m, 61 },
                    { 20, "Description for product 20", "Product 20", 812m, 72 },
                    { 19, "Description for product 19", "Product 19", 201m, 59 },
                    { 18, "Description for product 18", "Product 18", 171m, 86 },
                    { 17, "Description for product 17", "Product 17", 292m, 33 },
                    { 16, "Description for product 16", "Product 16", 678m, 59 },
                    { 15, "Description for product 15", "Product 15", 589m, 39 },
                    { 14, "Description for product 14", "Product 14", 777m, 31 },
                    { 13, "Description for product 13", "Product 13", 496m, 93 },
                    { 12, "Description for product 12", "Product 12", 275m, 32 },
                    { 11, "Description for product 11", "Product 11", 344m, 25 },
                    { 10, "Description for product 10", "Product 10", 308m, 97 },
                    { 9, "Description for product 9", "Product 9", 179m, 53 },
                    { 8, "Description for product 8", "Product 8", 899m, 6 },
                    { 7, "Description for product 7", "Product 7", 193m, 64 },
                    { 6, "Description for product 6", "Product 6", 265m, 82 },
                    { 5, "Description for product 5", "Product 5", 556m, 3 },
                    { 4, "Description for product 4", "Product 4", 962m, 73 },
                    { 3, "Description for product 3", "Product 3", 595m, 53 },
                    { 2, "Description for product 2", "Product 2", 991m, 52 },
                    { 23, "Description for product 23", "Product 23", 624m, 20 },
                    { 24, "Description for product 24", "Product 24", 655m, 49 },
                    { 25, "Description for product 25", "Product 25", 792m, 82 },
                    { 26, "Description for product 26", "Product 26", 727m, 82 },
                    { 48, "Description for product 48", "Product 48", 953m, 2 },
                    { 47, "Description for product 47", "Product 47", 563m, 17 },
                    { 46, "Description for product 46", "Product 46", 678m, 44 },
                    { 45, "Description for product 45", "Product 45", 372m, 58 },
                    { 44, "Description for product 44", "Product 44", 958m, 85 },
                    { 43, "Description for product 43", "Product 43", 725m, 81 },
                    { 42, "Description for product 42", "Product 42", 595m, 72 },
                    { 41, "Description for product 41", "Product 41", 389m, 26 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 40, "Description for product 40", "Product 40", 763m, 23 },
                    { 39, "Description for product 39", "Product 39", 977m, 19 },
                    { 99, "Description for product 99", "Product 99", 313m, 3 },
                    { 38, "Description for product 38", "Product 38", 380m, 65 },
                    { 36, "Description for product 36", "Product 36", 959m, 49 },
                    { 35, "Description for product 35", "Product 35", 608m, 2 },
                    { 34, "Description for product 34", "Product 34", 653m, 76 },
                    { 33, "Description for product 33", "Product 33", 456m, 59 },
                    { 32, "Description for product 32", "Product 32", 270m, 11 },
                    { 31, "Description for product 31", "Product 31", 802m, 63 },
                    { 30, "Description for product 30", "Product 30", 172m, 61 },
                    { 29, "Description for product 29", "Product 29", 302m, 67 },
                    { 28, "Description for product 28", "Product 28", 128m, 49 },
                    { 27, "Description for product 27", "Product 27", 674m, 36 },
                    { 37, "Description for product 37", "Product 37", 773m, 50 },
                    { 100, "Description for product 100", "Product 100", 812m, 35 }
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

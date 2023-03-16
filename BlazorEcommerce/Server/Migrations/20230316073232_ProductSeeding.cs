using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "An apple mobile which is nothing like apple", "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-purple-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169055000", 549m, "New Apple iPhone 11 (64GB) - Purple" },
                    { 2, "An apple mobile which is nothing like apple", "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-black-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169026000", 549m, "New Apple iPhone 11 (64GB) - Black" },
                    { 3, "An apple mobile which is nothing like apple", "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-white-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169090000", 549m, "New Apple iPhone 11 (64GB) - White" },
                    { 4, "An apple mobile which is nothing like apple", "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-green-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169038000", 549m, "New Apple iPhone 11 (64GB) - Green" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { 5, 1, "The ultimate smartphone for productivity and creativity. With a pro-grade camera system, 5G connectivity, and an intelligent battery that lasts all day, you can do more of what you love, faster than ever before.", "https://images-na.ssl-images-amazon.com/images/I/41FGPAslf8L._SX300_SY300_QL70_FMwebp_.jpg", 1199m, "Samsung Galaxy S21 Ultra 5G" },
                    { 6, 2, "The thinnest, lightest Kindle Paperwhite yet, with a sleek, modern design so you can read comfortably for hours. Features a glare-free display that reads like real paper, even in bright sunlight.", "https://m.media-amazon.com/images/G/35/kindle/journeys/2FC4ihZAa5gdJ9XpXvMyHAeLB35Q0sgHEKFNabr2B3Iqg3D/NjNiYTE3ODQt._CB641041171_.jpg", 149.99m, "Amazon Kindle Paperwhite" },
                    { 7, 3, "The Air Max 2090 celebrates the iconic Air Max 90 with futuristic updates. Features a translucent rubber sole, new Air cushioning for unparalleled comfort, and a bold, modern design.", "https://assets.ajio.com/medias/sys_master/root/20221025/4e0v/6357f36daeb269659c593cd6/-473Wx593H-469258173-black-MODEL4.jpg", 150m, "Nike Men's Air Max 2090" },
                    { 8, 3, "The iconic straight fit with the signature button fly. Features a classic five-pocket styling, a comfortable waistband, and durable denim that only gets better with wear.", "https://myer-media.com.au/wcsstore/MyerCatalogAssetStore/images/40/406/3454/501/1/523738810/523738810_1_2_720x928.webp", 4971m, "Levi's Men's 501 Original Fit Jeans" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}

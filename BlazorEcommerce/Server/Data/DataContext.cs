namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                new Categories
                {
                    Id = 1,
                    Name = "Mobiles",
                    Url = "mobiles"
                },
                new Categories
                {
                    Id = 2,
                    Name = "Books",
                    Url = " books"
                },
                new Categories
                {
                    Id = 3,
                    Name = "Cloths",
                    Url = "cloths"
                });
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                        new Product
                        {
                            Id = 1,
                            Title = "New Apple iPhone 11 (64GB) - Purple",
                            Description = "A new dual camera system captures more of what you see and love. The fastest chip ever in a smartphone and all day battery life let you do more and charge less. And the highest quality video in a smartphone, so your memories look better than ever.",
                            ImageURL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-purple-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169055000",
                            Price = 549m,
                            CategoryId = 1
                        },
                        new Product
                        {
                            Id = 2,
                            Title = "New Apple iPhone 11 (64GB) - Black",
                            Description = "A new dual camera system captures more of what you see and love. The fastest chip ever in a smartphone and all day battery life let you do more and charge less. And the highest quality video in a smartphone, so your memories look better than ever.",
                            ImageURL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-black-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169026000",
                            Price = 549m,
                            CategoryId = 1
                        },
                        new Product
                        {
                            Id = 3,
                            Title = "New Apple iPhone 11 (64GB) - White",
                            Description = "A new dual camera system captures more of what you see and love. The fastest chip ever in a smartphone and all day battery life let you do more and charge less. And the highest quality video in a smartphone, so your memories look better than ever.",
                            ImageURL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-white-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169090000",
                            Price = 549m,
                            CategoryId = 1
                        },
                        new Product
                        {
                            Id = 4,
                            Title = "New Apple iPhone 11 (64GB) - Green",
                            Description = "A new dual camera system captures more of what you see and love. The fastest chip ever in a smartphone and all day battery life let you do more and charge less. And the highest quality video in a smartphone, so your memories look better than ever.",
                            ImageURL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-green-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169038000",
                            Price = 549m,
                            CategoryId = 1
                        },
                         new Product
                         {
                             Id = 5,
                             Title = "Samsung Galaxy S21 Ultra 5G",
                             Description = "The ultimate smartphone for productivity and creativity. With a pro-grade camera system, 5G connectivity, and an intelligent battery that lasts all day, you can do more of what you love, faster than ever before.",
                             ImageURL = "https://images-na.ssl-images-amazon.com/images/I/41FGPAslf8L._SX300_SY300_QL70_FMwebp_.jpg",
                             Price = 1199m,
                             CategoryId = 1
                         },
                         new Product
                         {
                             Id = 6,
                             Title = "Amazon Kindle Paperwhite",
                             Description = "The thinnest, lightest Kindle Paperwhite yet, with a sleek, modern design so you can read comfortably for hours. Features a glare-free display that reads like real paper, even in bright sunlight.",
                             ImageURL = "https://m.media-amazon.com/images/G/35/kindle/journeys/2FC4ihZAa5gdJ9XpXvMyHAeLB35Q0sgHEKFNabr2B3Iqg3D/NjNiYTE3ODQt._CB641041171_.jpg",
                             Price = 149.99m,
                             CategoryId = 2
                         },
                         new Product
                         {
                            Id = 7,
                            Title = "Nike Men's Air Max 2090",
                            Description = "The Air Max 2090 celebrates the iconic Air Max 90 with futuristic updates. Features a translucent rubber sole, new Air cushioning for unparalleled comfort, and a bold, modern design.",
                            ImageURL = "https://assets.ajio.com/medias/sys_master/root/20221025/4e0v/6357f36daeb269659c593cd6/-473Wx593H-469258173-black-MODEL4.jpg",
                            Price = 150m,
                            CategoryId = 3
                         },
                         new Product
                         {
                             Id = 8,
                             Title = "Levi's Men's 501 Original Fit Jeans",
                             Description = "The iconic straight fit with the signature button fly. Features a classic five-pocket styling, a comfortable waistband, and durable denim that only gets better with wear.",
                             ImageURL = "https://myer-media.com.au/wcsstore/MyerCatalogAssetStore/images/40/406/3454/501/1/523738810/523738810_1_2_720x928.webp",
                             Price = 4971m,
                             CategoryId = 3
                         }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}

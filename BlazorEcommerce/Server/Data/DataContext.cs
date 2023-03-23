namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                        new Product
                        {
                            Id = 1,
                            Title = "New Apple iPhone 11 (64GB) - Purple",
                            Description = "A new dual camera system captures more of what you see and love. The fastest chip ever in a smartphone and all day battery life let you do more and charge less. And the highest quality video in a smartphone, so your memories look better than ever.",
                            ImageURL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-purple-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169055000",
                            Price = 549m
                        },
                        new Product
                        {
                            Id = 2,
                            Title = "New Apple iPhone 11 (64GB) - Black",
                            Description = "A new dual camera system captures more of what you see and love. The fastest chip ever in a smartphone and all day battery life let you do more and charge less. And the highest quality video in a smartphone, so your memories look better than ever.",
                            ImageURL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-black-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169026000",
                            Price = 549m
                        },
                        new Product
                        {
                            Id = 3,
                            Title = "New Apple iPhone 11 (64GB) - White",
                            Description = "A new dual camera system captures more of what you see and love. The fastest chip ever in a smartphone and all day battery life let you do more and charge less. And the highest quality video in a smartphone, so your memories look better than ever.",
                            ImageURL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-white-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169090000",
                            Price = 549m
                        },
                        new Product
                        {
                            Id = 4,
                            Title = "New Apple iPhone 11 (64GB) - Green",
                            Description = "A new dual camera system captures more of what you see and love. The fastest chip ever in a smartphone and all day battery life let you do more and charge less. And the highest quality video in a smartphone, so your memories look better than ever.",
                            ImageURL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-green-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169038000",
                            Price = 549m
                        }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}

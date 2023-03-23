namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Sorry, Product does not exist.";
            }
            else
            {
                response.Success = true;
                response.Data = product;
                response.Message = "Product found";
            }
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
             var response = new ServiceResponse<List<Product>>()
             {
                 Data = await _context.Products.ToListAsync()
             };
            return response; 
            //throw new NotImplementedException();
        }
    }
}

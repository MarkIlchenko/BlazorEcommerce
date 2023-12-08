
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

            try
            {
                Product? product = await _context.Products
                    .Include(p => p.Variants)
                    .ThenInclude(v => v.Edition)
                    .FirstOrDefaultAsync(p => p.Id == productId);

                product.Views++;
                await _context.SaveChangesAsync();

                if (product == null)
                {
                    response.Success = false;
                    response.Message = "Sorry, but this product does not exist.";
                }
                else
                {
                    response.Data = product;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "An error occurred while fetching the product.";
            }

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Include(p => p.Variants).Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower())).ToListAsync()
            };

            return response;
        }



        public async Task<ServiceResponse<List<Product>>> GetProductListAsync()
        {
            var response = new ServiceResponse<List<Product>> 
            { 
                Data = await _context.Products.Include(p => p.Variants).ToListAsync()
            };

            return response;
        }

        public async Task<List<Product>> SearchProducts(string searchText)
        {
            return await _context.Products
                .Where(p => p.Title.Contains(searchText) || p.Description.Contains(searchText))
                .ToListAsync();
        }
    }
}

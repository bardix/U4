namespace ShopScarpe.Models
{
    public static class ProductRepository
    {
        private static List<Product> _products = new List<Product>();

        public static List<Product> GetAllProducts()
        {
            return _products;
        }

        public static void AddProduct(Product product)
        {
            product.Id = _products.Count + 1; // Assegniamo un ID univoco (semplificazione)
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }

}

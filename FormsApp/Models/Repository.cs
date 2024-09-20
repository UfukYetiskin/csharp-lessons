namespace FormsApp.Models
{
    // Repository sınıfı ürünler ve kategoriler için statik veri depolayan bir sınıftır.
    public class Repository
    {
        // Ürünler için statik ve sadece bu sınıf içinde değiştirilebilecek bir liste.
        private static readonly List<Product> _products = new();

        // Kategoriler için statik ve sadece bu sınıf içinde değiştirilebilecek bir liste.
        private static readonly List<Category> _categories = new();

        // Statik yapıcı (constructor), sınıfın ilk kullanımında çalışır ve statik verileri başlatabilir.
        static Repository()
        {
            _categories.Add(new Category{CategoryId =1, Name ="Telefon"});
            _categories.Add(new Category{CategoryId = 2, Name = "Bilgisayar"});

            _products.Add(new Product{ProductId = 1, Name = "IPhone 14", Price = 40000, IsActive = true, Image = "1.jpg", CategoryId = 1});
            _products.Add(new Product{ProductId = 2, Name = "IPhone 15", Price = 25000, IsActive = false, Image = "1.jpg", CategoryId = 1});
            _products.Add(new Product{ProductId = 3, Name = "MacBook Air", Price = 50000, IsActive = true, Image = "1.jpg", CategoryId = 2});
            _products.Add(new Product{ProductId = 4, Name = "MacBook Pro", Price = 60000, IsActive = false, Image = "1.jpg", CategoryId = 2});

        }

        // Products adında statik bir property, dışarıdan ürün listesine sadece okunabilir şekilde erişim sağlar.
        public static List<Product> Products
        {
            get
            {
                // Ürün listesini döner.
                return _products;
            }
        }

        // Categories adında statik bir property, dışarıdan kategori listesine sadece okunabilir şekilde erişim sağlar.
        public static List<Category> Categories
        {
            get
            {
                // Kategori listesini döner.
                return _categories;
            }
        }

        public static void CreateProduct(Product product){
            product.ProductId = Products.Count +1;
            _products.Add(product);
        }
    }
}

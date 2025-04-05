namespace NguyenPhiTruong_2122110563.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public double Price { get; set; }

        // 🔹 Liên kết với Brand (One-to-Many)
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = new Brand();

        // 🔹 Liên kết với Category (One-to-Many)
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new Category();

        // 🔹 Liên kết với User (One-to-Many)
        public int UserId { get; set; }
        public User User { get; set; } = new User();
    }
}

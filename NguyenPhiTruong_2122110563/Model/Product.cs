namespace NguyenPhiTruong_2122110563.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }


        // 🔹 Liên kết với Brand (One-to-Many)
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }
        
      


        // 🔹 Liên kết với Category (One-to-Many)
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        // 🔹 Liên kết với User (One-to-Many)
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}

namespace TruongThiKimSuong_b2.Model
{
    public class Cart
    {
        public int CartId { get; set; }
        public string UserId { get; set; }  // ID của người dùng (nếu có đăng nhập)

        // Danh sách sản phẩm trong giỏ hàng
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}

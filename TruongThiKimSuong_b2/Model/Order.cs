using TruongThiKimSuong_b2.Model;

namespace TruongThiKimSuong_b2.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public double TotalAmount { get; set; }

        // Danh sách sản phẩm trong đơn hàng
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
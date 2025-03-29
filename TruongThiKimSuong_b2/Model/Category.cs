using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TruongThiKimSuong_b2.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; } // Quan hệ 1-N với Product
    }
}

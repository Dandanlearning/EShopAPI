using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationCore.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Product Name is required")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Product_Img { get; set; }
        public int SKU { get; set; }
        [ForeignKey("CategoryId")]
        public ProductCategory Category { get; set; }
        public IEnumerable<ProductVariation> Variations { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationCore.Entity
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("ParentCategory")]
        public string ParentCategoryId { get; set; }
        public IEnumerable<CategoryVariation> CategoryVariations { get; set; }
        public IEnumerable<Product> Products { get; set; }

    }
}

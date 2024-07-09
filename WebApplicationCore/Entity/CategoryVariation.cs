using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationCore.Entity
{
    public class CategoryVariation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public ProductCategory Category { get; set; }
        public IEnumerable<VariationValue> Variations { get;set; }
    }
}

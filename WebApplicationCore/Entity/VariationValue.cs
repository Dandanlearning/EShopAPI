using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationCore.Entity
{
    public class VariationValue
    {
        public int Id { get; set; }
        [ForeignKey("VariationId")]
        public int VariationId { get; set; }
        public int value { get; set; }
        public CategoryVariation Category { get; set; }
        public IEnumerable<ProductVariation> ProductVariation { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationCore.Entity
{
    [PrimaryKey(nameof(ProductId), nameof(VariationId))]
    public class ProductVariation
    {
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [ForeignKey("VariationId")]
        public int VariationId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Product Product { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public VariationValue VariationValue { get; set; }
    }
}

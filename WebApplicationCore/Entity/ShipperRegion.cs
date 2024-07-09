using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationCore.Entity
{
    [PrimaryKey(nameof(RegionId), nameof(ShipperId))]
    public class ShipperRegion
    {
        [ForeignKey("RegionId")]
        public int RegionId { get; set; }
        [ForeignKey("ShipperId")]
        public int ShipperId { get; set; }
        public Region Region { get; set; }
        public Shipper Shipper { get; set; }
    }
}

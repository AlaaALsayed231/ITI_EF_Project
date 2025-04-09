using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_final_Project.Models
{
    public class Product
    {
        [Key]
        public int Code { get; set; }
        [MaxLength(30)]
        public string? Name { get; set; }
        public int? Scale { get; set; }
        public string? Vender { get; set; }
        public string? PdtDescription { get; set; }
        public int QlylnStock { get; set; }

        [Column(TypeName = "decimal(19,2)")]
        public decimal BuyPrice { get; set; }
        public string? MSRP { get; set; }

        [ForeignKey("ProductLine")]
        public int ProductlnID { get; set; }
        public virtual ProductLine ProductLine { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();


    }
}

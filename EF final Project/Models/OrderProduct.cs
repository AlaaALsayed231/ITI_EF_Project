using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_final_Project.Models
{
    
    public class OrderProduct
    {
        [Key]
        public int ID { get; set; }
        public int Qty { get; set; }
        public int PriceEach { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        [ForeignKey("Product")]
        public int ProductCode { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
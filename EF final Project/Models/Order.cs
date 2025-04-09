using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_final_Project.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReqiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int Status { get; set; }
        public string? Comments { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();
    }
}

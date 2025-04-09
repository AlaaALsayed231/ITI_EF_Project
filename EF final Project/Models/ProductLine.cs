using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_final_Project.Models
{
    public class ProductLine
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(255)]
        public string? DesclnText { get; set; }
        public string? DesclnHTML { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}

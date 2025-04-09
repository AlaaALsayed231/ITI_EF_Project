using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_final_Project.Models
{
    public class Payment
    {
        [Key]
        public int CheckNum { get; set; }
        public DateTime PaymentDate { get; set; }

        public int Amount { get; set; }

        [ForeignKey("Customer")]
        public int CutomerID { get; set; }
        public virtual Customer Customer { get; set; }

    }
}

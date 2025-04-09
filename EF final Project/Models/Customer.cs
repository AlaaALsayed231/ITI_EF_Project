using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_final_Project.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(30)]
        public string? Name { get; set; }
        [MaxLength(30)]
        public string? LastName { get; set; }
        [MaxLength(30)]
        public string? FirstName { get; set; }
        public string ? Phone { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string ?State { get; set; }
        public int PostalCode { get; set; }
        public string? Country { get; set; }
        public int CreditLimit { get; set; }
       
        public virtual ICollection<Payment> Payments { get; set; } = new HashSet<Payment>();
        [ForeignKey("Employee")]
        public int SalesRepEmployeeNum { get; set; }
        public virtual Employee Employee { get; set; }


        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}

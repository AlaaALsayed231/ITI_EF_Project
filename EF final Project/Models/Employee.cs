using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_final_Project.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(30)]
        public string? FirstName { get; set; }
        [MaxLength(30)]
        public string? LastName { get; set; }
        public string? Extention { get; set; }

        public string? Email { get; set; }
        public string? JobTitle { get; set; }

        [ForeignKey("office")]
        public int OfficeCode;
        public Office office { get; set; }

        public virtual ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();

        //[ForeignKey("Manger")]
        //public int? ReportsTo { get; set; }
        //public virtual Employee? Manger { get; set; } 
        //public virtual ICollection<Employee> EmployeeManger { get; set; } = new HashSet<Employee>();

        [ForeignKey(nameof(Manager))]
        //[ForeignKey("Manager")]
        public int? reportTo { get; set; }
        public virtual Employee Manager { get; set; } = null!;
        
        public ICollection<Employee> ManagedEmployees { get; set; } = new List<Employee>();
    }
}

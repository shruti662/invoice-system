using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice_system.database
{
    public class description_details
    {
        [Key]
        public int description_ID {  get; set; }

        [ForeignKey("work_ID")]
        public int work_ID { get; set; }
        public string description_name { get; set; }
        public decimal total_value { get; set; }
        public decimal total_amount{ get; set;}
        public decimal percentage_value { get; set; }
        public DateTime? created_date { get; set; }
        public int created_by { get; set; }
        public DateTime? modified_date { get; set; }
        public int modified_by { get; set; }
        public bool IsDeleted { get; set; }
        public int invoiceId { get; set; }
        public int TotalPrice { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }


    }
}


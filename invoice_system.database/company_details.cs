using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace invoice_system.Database
{
    public class company_details
    { 
        [Key]
        
        public int company_ID { get; set; }
        
        public string company_name { get; set; }

        public string company_email { get; set; }
        public long? contact_no { get; set; } 
        public long? landline_no { get; set; } 

        [Required]
        public string PAN_no { get; set; }

        [Required]
        public string GSTIN_no { get; set; }
        public DateTime? created_date { get; set; }
        public int created_by { get; set; }
        public DateTime? modified_date { get; set; }
        public int modified_by { get; set; }
        public bool IsDeleted { get; set; }
    }
}

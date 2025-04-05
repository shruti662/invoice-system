using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice_system.database
{
    public class concern_person_detail
    {
        [Key]
        public int person_ID { get; set; }
        public int company_ID { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }

    }
}
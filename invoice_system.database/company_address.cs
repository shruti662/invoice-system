using System.ComponentModel.DataAnnotations;

namespace invoice_system.database
{
    public class company_address
    {
        [Key]
        public int address_ID { get; set; }
        public int company_ID { get; set; } 
        public string street_address { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public int pin_code { get; set; }
        public int country_ID { get; set;}
    }

}
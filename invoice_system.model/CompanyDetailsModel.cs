using System.Collections.Generic;

namespace invoice_system.Model
{
    public class CompanyDetailsModel
    {
        public int company_ID { get; set; }
        public int address_ID { get; set; }
        public int person_ID { get; set; }
        public string company_name { get; set; }
        public string company_email { get; set; }
        public long? contact_no { get; set; }
        public long? landline_no { get; set; }
        public string PAN_no { get; set; }
        public string GSTIN_no { get; set; }
        public string company_address { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public int city_ID { get; set; }
        public int state_ID { get; set; }
        public int country_ID { get; set; }
        public string country_name { get; set; }
        public string state_name { get; set; }
        public string city_name { get; set; }
        public int pin_code { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public DateTime created_date { get; set; }
        public int created_by { get; set; } = 0;      
        public DateTime? modified_date { get; set; }
        public int modified_by { get; set; } = 0;
        public bool IsDeleted { get; set; }
    }
}

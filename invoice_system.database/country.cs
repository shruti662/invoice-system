using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace invoice_system.database
{
    public class City
    {
        [Key]
        [Column("city_ID")] 
        public int city_ID { get; set; }

        [Required]
        [Column("city_name")] 
        public string city_name { get; set; }
        [ForeignKey("StateId")]
        public int state_ID { get; set; }

    }

    public class State
    {
        [Key]
        [Column("state_ID")] 
        public int state_ID { get; set; }

       
        public string state_name { get; set; }

        [ForeignKey("Country")]
        public int country_ID { get; set; }

   
    }

    public class Country
    {
        [Key]
        public int country_ID { get; set; }       
        public string country_name { get; set; }
    }
}
using invoice_system.database;
using invoice_system.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice_system.Model
{
    public class InvoiceViewModel
    {
        public company_details company { get; set; } = new();
        public company_address Address { get; set; } = new();
        public Country Country { get; set; } = new();
        public List<description_details> Descriptions { get; set; } = new();
        public List<work_order_details> WorkOrders { get; set; } = new();
        public List<concern_person_detail> ConcernPerson { get; set; }
        public decimal TotalAmount { get; set; } // Store total invoice amount
        public int CompanyID { get; set; }
    }

    public class WorkOrderViewModel
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class InvoiceDetailsViewModel
    {
        [Key]
        public int company_ID { get; set; }
        public string company_name { get; set; }
        public string PAN_no { get; set; }
        public string GSTIN_no { get; set; }

        // Address Details
        public string street_address { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public int pin_code { get; set; }

        // **List to store multiple tax details**
        public List<TaxDetailViewModel> TaxDetails { get; set; } = new List<TaxDetailViewModel>();

        // Concern Person Details
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }

        public string FullName
        {
            get
            {
                return $"{first_name} {middle_name} {last_name}".Trim(); // Remove extra spaces
            }
        }
    }

    // **New Model for Tax Details**
    public class TaxDetailViewModel
    {
        public int work_ID { get; set; }
        public string Description { get; set; }
        public decimal Percentage { get; set; }
        public decimal TotalAmount { get; set; }
    }
}

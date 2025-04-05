using invoice_system.database;
using invoice_system.Database;
using Microsoft.AspNetCore.Http;
using System;

namespace invoice_system.repositories
{
    public class CompanyDetailsRepository : GenericRepository<company_details>
    {
        private readonly InvoiceSystemDbContext _context;

        public CompanyDetailsRepository(InvoiceSystemDbContext context, IHttpContextAccessor httpContextAccessor) : base(context)
        {
            _context = context;
        }
        public void AddCompanyDetails(company_details model)
        {
            var objtbl = new company_details
            {
                //company_ID = model.company_ID,
                company_name = model.company_name,
                company_email = model.company_email,
                //company_address = model.company_address,
                contact_no = model.contact_no,
                landline_no = model.landline_no,
                PAN_no = model.PAN_no,
                GSTIN_no = model.GSTIN_no,
                
            };


            _context.company_details.Add(objtbl);
            _context.SaveChanges();
        }
        public void AddCompanyAddress(company_address model)
        {
            var objtbl = new company_address
            {
                country = model.country,
                state = model.state,
                city = model.city,
                //city_ID = model.city_ID,
                //state_ID = model.state_ID,
                //country_ID = model.country_ID,
                //country_name = model.country_name,
                //state_name = model.state_name,
                //city_name = model.city_name,
                pin_code = model.pin_code,
            };
            //_context.company_address.Add(objtbl);
            //_context.SaveChanges();
        }
        public void AddConcernPersonDetails(concern_person_detail model)
        {
            var objtbl = new concern_person_detail
            {

                first_name = model.first_name,
                middle_name = model.middle_name,
                last_name = model.last_name
            };
            //_context.concern_person_details.Add(objtbl);
            //_context.SaveChanges();
        }
        public List<City> GetCitiesByState(int stateId)
        {
            return _context.city
                .Where(c => c.state_ID == stateId)
                .ToList();
        }

        public List<State> GetStatesByCountry(int countryId)
        {
            return _context.state
                .Where(s => s.country_ID == countryId)
                .ToList();
        }


    }
}
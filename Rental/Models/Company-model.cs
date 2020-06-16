using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Models
{
    public class Company_model
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Whatsapp { get; set; }
    }
}

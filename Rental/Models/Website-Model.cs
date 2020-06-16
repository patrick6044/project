using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Models
{
    public class Website_Model
    {  
        //company Infor
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Whatsapp { get; set; }


        //Masterhead
        public int MasterheadId { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }

        //About
        public int AboutId { get; set; }
        public string ATitle { get; set; }
        public string ABody { get; set; }
        public DateTime Date { get; set; }

    }
}
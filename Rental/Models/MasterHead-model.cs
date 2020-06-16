using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Models
{
    public class MasterHead_model
    {
        public int MasterheadId { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
}
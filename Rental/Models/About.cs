using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Models
{
    public class About
    {
        public int AboutId { get; set; }
        public string ATitle { get; set; }
        public string ABody { get; set; }
        public DateTime Date { get; set; }
    }
}
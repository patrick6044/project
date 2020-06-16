using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Models
{
    public class Comment_model
    {
        public int CommentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestMovies.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public int Discount { get; set; }
    }
}
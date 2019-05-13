using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToColoradoBeer.Models
{
    public class BeerReview
    {
        public object Country;
        public object State;
        public object City;
        public object Name;
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }
        public int BeerId { get; set; }
    }
}
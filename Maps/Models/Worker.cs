using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maps.Models
{
    public class Worker
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string photo { get; set; }
    }
}
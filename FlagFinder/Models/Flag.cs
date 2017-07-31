using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlagFinder.Models
{
    public class Flag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageLocation { get; set; }
        public bool Red { get; set; }
        public bool Orange { get; set; }
        public bool Yellow { get; set; }
        public bool Green { get; set; }
        public bool Blue { get; set; }
        public bool Purple { get; set; }
        public bool Brown { get; set; }
        public bool White { get; set; }
        public bool Black { get; set; }
    }
}
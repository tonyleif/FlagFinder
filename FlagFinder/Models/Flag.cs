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
        public string ShortName { get; set; }
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
        public bool Circle { get; set; }
        public bool Triangle { get; set; }
        public bool Star { get; set; }
        public bool Sun { get; set; }
        public bool Moon { get; set; }
        public bool Cross { get; set; }
        public bool TriColorHorizontal { get; set; }
        public bool TriColorVertical { get; set; }
        public bool BiColorHorizontal { get; set; }
    }
}
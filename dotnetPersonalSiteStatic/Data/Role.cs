using System;
using System.Collections.Generic;

namespace dotnetPersonalSiteStatic.Data
{
    public class Role
    {
        public string Title { get; set; }
        public string StartDateString { get; set; }
        public string EndDateString { get; set; }
        public List<string> Experience { get; set; }
    }
}

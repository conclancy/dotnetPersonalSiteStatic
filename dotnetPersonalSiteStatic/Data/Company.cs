using System;
using System.Collections.Generic;

namespace dotnetPersonalSiteStatic.Data
{
    public class Company
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public List<Role> Roles { get; set; }
    }
}

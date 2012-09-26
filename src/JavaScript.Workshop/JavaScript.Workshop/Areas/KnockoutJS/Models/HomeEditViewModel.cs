using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JavaScript.Workshop.Areas.KnockoutJS.Models
{
    public class KnockoutEditViewModel
    {
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public bool IsScary { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public int Number { get; set; }
    }
}
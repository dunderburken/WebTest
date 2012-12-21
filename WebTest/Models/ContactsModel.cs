using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest.Models
{
    public class ContactsModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<Phone> phones { get; set; }
    }

    public class Phone
    {
        public string type { get; set; }
        public string number { get; set; }
    }
}

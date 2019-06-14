using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ToffLeadDev
{
    public class ToffLead
    {
        public string product { get; set; }
        public string source { get; set; }
        public string subsource { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public bool isHot { get; set; }
        public string companyName { get; set; }
        public string innOrOgrn { get; set; }
        public string comment { get; set; }
        public string temperature { get; set; }
    }
}

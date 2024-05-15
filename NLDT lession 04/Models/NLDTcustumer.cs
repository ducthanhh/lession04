using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace NLDT_lession_04.Models
{
    public class NLDTcustumer
    {
        public  int Custumerid { get; set; }
        public string Firtname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int YearofBirth  { get; set; }
    }
}
using NLDT_lession_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace NLDT_lession_04.Controllers
{
    public class NLDTcustumerController : Controller
    {
        // GET: NLDTcustumer
        public ActionResult Index()
        {
            return View();

        }
        public ActionResult NLDTcustomerDetail()
        {
            var Customer = new NLDTcustomer()
            { 
            Customer = 1,
            firstname = "nguyen le",
            Lastname = "duc thanh",
            YearOfBirth = 2004
         };
            ViewBag.customer = Customer;
            return ViewO;

        }
        public ActionResult NLDTListCustomer()
        {
            var list = new List<NLDTcustumer>()
                new NLDTCustomer()
                {
                    Customer = 1,
                    firtname = "nguyen le ",
                    lastname = "duc thanh",
                    AddressFamily = "k22cntt3",
                    YearOFBirth = 2004
                },
                new NLDTcustomer()
                {
                    Customer = 2,
                    firtname = "nguyen le ",
                    lastname = "duc anh",
                    AddressFamily = "k22cntt3",
                    YearOFBirth = 2004
                },
                new NLDTcustomer()
                {
                    Customer = 3,
                    firtname = "nguyen le ",
                    lastname = "duc anh",
                    AddressFamily = "k22cntt3",
                    YearOFBirth = 2004
                },
                new NLDTcustomer()
                {
                    Customer = 4,
                    firtname = "nguyen le ",
                    lastname = "duc thanh",
                    AddressFamily = "k22cntt3",
                    YearOFBirth = 2004
                },
              };
        ViewBag.list = List;
            return View();
    }
}

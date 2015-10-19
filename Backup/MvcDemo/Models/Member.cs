using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Models
{
    public class Member : Controller
    {
        //
        // GET: /Member/

        public int MemberID{ get; set; }
        public string MemberName{ get; set; }
        public string MemberAddress{ get; set; }
        public int MemberAge{ get; set; }

    }
}

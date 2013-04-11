using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PADa4.Controllers
{
    public class FiringCodeController : ApiController
    {
        public string CheckCode(string code)
        {
            string ret = "DRILL";
            if (code == "AZ035T29Z1984")
            {
                ret = "AUTHENTICATED";
            }
            return ret;
        }
    }
}

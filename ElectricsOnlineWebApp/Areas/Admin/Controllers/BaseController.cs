using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectricsOnlineWebApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BaseController : Controller
    {
        protected ElectricsOnlineEntities _ctx = new ElectricsOnlineEntities();
    }
}
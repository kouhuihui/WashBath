using Microsoft.AspNet.Identity;
using WashBath.Managers;
using WashBath.Protal.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WashBath.Protal.Controllers
{
    public class RoleController : PortalController
    {
        // GET: Role
        [UrlAuthorize]
        public async Task<ActionResult> List()
        {
            var manager = new RoleManager(User);
            var roles =await manager.GetRolesAsync();
            return View(roles);
        }
    }
}
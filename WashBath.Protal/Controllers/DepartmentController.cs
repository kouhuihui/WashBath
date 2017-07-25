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
    public class DepartmentController : PortalController
    {
        // GET: Department
        public async Task<ActionResult> List()
        {
            var manager = new DepartmentManager(User);
            var departments =await manager.GetDepartmentsAsync();

            return View(departments);
        }
    }
}
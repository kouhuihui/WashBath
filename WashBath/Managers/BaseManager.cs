using WashBath.Core.Models;
using WashBath.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashBath.Managers
{
    public class BaseManager : WashBathSerivce
    {
        public SaleUser User { get; set; }

        public BaseManager()
        {
        }

        public BaseManager(SaleUser user)
        {
            User = user;
        }
    }
}

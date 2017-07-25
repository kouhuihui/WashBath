using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using WashBath.Core.Models;

namespace WashBath.Managers
{
    public class SystemMenuManager : BaseManager
    {
        public async Task<ICollection<SystemMenu>> GetSystemMenusAsync()
        {
            return await DbContext.Set<SystemMenu>().ToListAsync();
        }
    }
}

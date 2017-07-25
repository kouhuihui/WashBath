using System.Threading.Tasks;
using System.Web.Http;
using WashBath.Managers;

namespace WashBath.Open.Controllers
{
    public class UserController : ApiController
    {
        public async Task<IHttpActionResult> GetUsers()
        {
            var userManager = new UserManager();
            var users = await userManager.GetAllCustomersAsync();
            return Ok(users);
        }
    }
}

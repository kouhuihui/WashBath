using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using WashBath.Managers;
using WashBath.Open.Models.User;

namespace WashBath.Open.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> GetUsers(UserQueryRequest request)
        {
            var userManager = new UserManager();
            var paging = await userManager.GetSaleUsersAsync(request.Start, request.PageSize, request.GetCustomerListQueryFilter());
            var users = paging.List.Select(r => new UserListItemViewModel(r));

            return Ok(new
            {
                paging.Total,
                List = users,
            });
        }
    }
}

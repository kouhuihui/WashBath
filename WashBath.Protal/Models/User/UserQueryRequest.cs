using WashBath.Core.Models;
using WashBath.Core.ViewModel;
using System;
using System.Linq;

namespace WashBath.Protal.Models.User
{
    public class UserQueryRequest : PagingRequest
    {
        public string UserName { get; set; }

        public UserStatus? Status { get; set; }

        public Func<IQueryable<Core.Models.SaleUser>, IQueryable<Core.Models.SaleUser>> GetUseristQueryFilter()
        {
            Func<IQueryable<Core.Models.SaleUser>, IQueryable<Core.Models.SaleUser>> filter = query =>
            {
                if (!string.IsNullOrEmpty(UserName))
                {
                    query = query.Where(f => f.Name.Contains(UserName));
                }

                if (Status.HasValue)
                {
                    query = query.Where(f => f.Status == Status.Value);
                }
                return query;
            };
            return filter;
        }
    }
}
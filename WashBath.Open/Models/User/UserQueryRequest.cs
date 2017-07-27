using System;
using System.Linq;
using WashBath.Core.ViewModes;

namespace WashBath.Open.Models.User
{
    public class UserQueryRequest : PagingRequest
    {
        public string UserName { get; set; }

        public UserStatus? Status { get; set; }

        public Func<IQueryable<Core.Models.SaleUser>, IQueryable<Core.Models.SaleUser>> GetCustomerListQueryFilter()
        {
            Func<IQueryable<Core.Models.SaleUser>, IQueryable<Core.Models.SaleUser>> filter = query =>
            {
                query = query.AsQueryable();
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
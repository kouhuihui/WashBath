using Dickson.Library.Security.Principal;
using WashBath.Core.Models;
using WashBath.Core.ViewModes;

namespace WashBath.Open.Models.User
{
    public class UserListItemViewModel : IUser
    {

        public string Id { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string Telephone { get; set; }

        public UserStatus Status { get; set; }

        public int CompanyId { get; set; }

        public Role Role { get; set; }

        public UserListItemViewModel(SaleUser user)
        {
            Id = user.Id;
            Name = user.Name;
            UserName = user.UserName;
            Email = user.Email;
            Telephone = user.Telephone;
            Status = user.Status;
            Role = user.Role;
        }
    }
}
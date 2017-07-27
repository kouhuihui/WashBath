using System.Data.Entity;
using WashBath.Core.Models;

namespace WashBath.Core.Store
{
    public class WashBathDbContext : DbContext
    {
        public WashBathDbContext() : this(null)
        {
        }

        public WashBathDbContext(string nameOrConnectionString) : base(nameOrConnectionString ?? "WashBathDbContext")
        {
        }


        public IDbSet<SaleUser> SaleUsers { get; set; }

        //public IDbSet<Department> Departments { get; set; }

        //public IDbSet<FileInfo> FileInfos { get; set; }

        public IDbSet<Role> Roles { get; set; }

        //public IDbSet<RoleMenu> RoleMenus { get; set; }

        //public IDbSet<SerialNumber> SerialNumbers { get; set; }

        //public IDbSet<SystemMenu> Menus { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}

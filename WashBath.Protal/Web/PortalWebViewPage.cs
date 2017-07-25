using WashBath.Protal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WashBath.Protal.Web
{
    public abstract class PortalWebViewPage : PortalWebViewPage<object>
    {
    }

    public abstract class PortalWebViewPage<TModel> : Dickson.Web.Mvc.DciksonUserWebViewPage<TModel, string, SaleUserViewModel>
    {
        public void Title(string title)
        {
            ViewBag.Title = title + WashBath.Core.SaleManagentConstants.UI.TitleSuffix;
        }

        public bool ShowWithRoles(params string[] roles)
        {
            if (roles == null || roles.Length == 0)
                throw new ArgumentException("roles不能为空");

            bool inRoles = false;
            if (User != null && User.Role != null)
            {
                inRoles = roles.Contains(User.Role.Code);
            }

            return inRoles;
        }
    }
}
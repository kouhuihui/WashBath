using System.ComponentModel.DataAnnotations;

namespace WashBath.Core.ViewModes
{
    public enum UserStatus
    {
        [Display(Name = "已禁用")]
        Disabled = 0,

        [Display(Name = "正常")]
        Normal = 1,
    }
}

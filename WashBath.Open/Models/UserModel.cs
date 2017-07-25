using Dickson.Library.Common;
using System.ComponentModel.DataAnnotations;
using WashBath.Core;

namespace WashBath.Open.Models
{
    public class UserModel
    {
        [Display(Name = "姓名"), Required(ErrorMessage = "请填写{0}"), StringLength(SaleManagentConstants.Validations.DefaultNameStringLength)]
        public string Name { get; set; }

        [Display(Name = "用户名"), Required(ErrorMessage = "请填写{0}"), StringLength(SaleManagentConstants.Validations.UserNameStringLength)]
        public string UserName { get; set; }

        [Display(Name = "联系电话"), StringLength(SaleManagentConstants.Validations.PhoneStringLength)]
        public string Telephone { get; set; }

        [Display(Name = "邮箱"), StringLength(SaleManagentConstants.Validations.EmailStringLength)]
        [RegularExpression(GlobalRegularPattern.SimplyEmail, ErrorMessage = "请输入正确的{0}")]
        public string Email { get; set; }

        [Display(Name = "密码"), DataType(DataType.Password), Required(ErrorMessage = "请填写{0}")]
        [StringLength(SaleManagentConstants.Validations.PasswordStringLength, ErrorMessage = "{0}最长支持{1}个字符")]
        [MinLength(6, ErrorMessage = "请输入至少6位密码")]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare("Password", ErrorMessage = "两次密码输入不一致")]
        public string ConfirmPassword { get; set; }
    }
}
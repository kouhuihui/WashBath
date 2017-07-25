using System.ComponentModel.DataAnnotations;

namespace WashBath.Protal.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "{0}不能为空")]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }
    }
}
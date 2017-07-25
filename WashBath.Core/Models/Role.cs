using System.ComponentModel.DataAnnotations;

namespace WashBath.Core.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required, StringLength(SaleManagentConstants.Validations.DefaultNameStringLength)]
        public string Name { get; set; }

        [Required, StringLength(SaleManagentConstants.Validations.GeneralShorterStringLength)]
        public string Code { get; set; }

        [StringLength(SaleManagentConstants.Validations.DefaultStringLength)]
        public string Description { get; set; }

        public bool Deleted { get; set; }
    }
}

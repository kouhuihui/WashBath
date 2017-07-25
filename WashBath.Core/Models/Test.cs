using System.ComponentModel.DataAnnotations.Schema;

namespace WashBath.Core.Models
{
    [Table("Tests")]
    public class Test
    {
        public string Id { get; set; }
    }
}

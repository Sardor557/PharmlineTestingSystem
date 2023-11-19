using PharmlineTestingSystem.Models.BaseModels;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PharmlineTestingSystem.Models
{
    public class tbUser : BaseModel
    {
        public int Id { get; set; }

        [StringLength(20), IndexColumn(IsUnique = true), Required]
        public string Login { get; set; }

        [StringLength(50), Required]
        public string Password { get; set; }

        [StringLength(300)]
        public string FIO { get; set; }
    }
}

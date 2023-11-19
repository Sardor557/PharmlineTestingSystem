using Newtonsoft.Json;
using PharmlineTestingSystem.Models.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PharmlineTestingSystem.Models
{
    public class tbEmployee : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100), Required, IndexColumn]
        public string FullName { get; set; }

        [StringLength(20), Required, IndexColumn(IsUnique = true)]
        public string Phone { get; set; }

        public long? TelegramId { get; set; }

        [StringLength(255), JsonIgnore]
        public string Password { get; set; }
    }
}

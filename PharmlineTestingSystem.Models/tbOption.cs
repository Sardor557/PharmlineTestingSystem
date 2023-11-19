using PharmlineTestingSystem.Models.BaseModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PharmlineTestingSystem.Models
{
    public class tbOption : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Answer { get; set; }

        public int QuestionId { get; set; }
        public virtual tbQuestion Question { get; set; }

        [StringLength(2)]
        public string Variant { get; set; }
        public bool IsCorrect { get; set; }
    }
}

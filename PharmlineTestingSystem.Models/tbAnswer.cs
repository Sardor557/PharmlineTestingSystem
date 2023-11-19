using PharmlineTestingSystem.Models.BaseModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PharmlineTestingSystem.Models
{
    public class tbAnswer : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int QuestionId { get; set; }
        public virtual tbQuestion Question { get; set; }

        public int EmployeeId { get; set; }
        public virtual tbEmployee Employee { get; set; }

        public int OptionId { get; set; }
        public virtual tbOption Option { get; set; }
    }
}

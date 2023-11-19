using PharmlineTestingSystem.Models.BaseModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmlineTestingSystem.Models
{
    public sealed class spDrug : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public void Validate()
        {
            if (this is null) throw new Exception("Модель пустая");
            if (Name is null || Name.Length < 1) throw new Exception("Имя не задано");
        }
    }
}

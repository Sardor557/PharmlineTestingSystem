using PharmlineTestingSystem.Models.BaseModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace PharmlineTestingSystem.Models
{
    public class tbQuestion : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(2000)]
        public string Context { get; set; }

        public int DrugId {  get; set; }
        public virtual spDrug Drug { get; set; }

        public bool IsOpen { get; set; }
        public virtual List<tbOption> Options { get; set; }


        public void Validate()
        {
            if (this is null) throw new Exception("Форма пустая");
            if (this.Context is null) throw new Exception("Контекст пустой");
            if (this.DrugId == 0) throw new Exception("Препарат не выбран");
            if (this.Options is null || this.Options.Count < 1) throw new Exception("Варианты ответов не введены");
        }
    }
}

using Newtonsoft.Json;
using PharmlineTestingSystem.Models.BaseModels;
using System;
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

        [StringLength(255)]
        public string Password { get; set; }

        public void Validate()
        {
            if (this is null) throw new Exception("Форма пустая");
            if (FullName is null || FullName.Length < 1) new Exception("Ф.И.О не введено");
            if (Phone is null || Phone.Length < 1) new Exception("Номер не введен");
            if (Password is null || Password.Length < 1) new Exception("Пароль не введен");
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace PharmlineTestingSystem.Shared.ViewModels
{
    public sealed class viUserRegister
    {
        [Required]
        [StringLength(100)]
        public string SurName { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Patronymic { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
    }
}

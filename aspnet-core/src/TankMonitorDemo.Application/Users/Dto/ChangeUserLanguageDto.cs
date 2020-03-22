using System.ComponentModel.DataAnnotations;

namespace TankMonitorDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace TokenR.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
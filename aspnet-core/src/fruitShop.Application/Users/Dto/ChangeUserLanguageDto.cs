using System.ComponentModel.DataAnnotations;

namespace fruitShop.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
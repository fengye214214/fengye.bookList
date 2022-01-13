using System.ComponentModel.DataAnnotations;

namespace fengye.bookList.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
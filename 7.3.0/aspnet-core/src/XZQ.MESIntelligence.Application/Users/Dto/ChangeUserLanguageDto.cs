using System.ComponentModel.DataAnnotations;

namespace XZQ.MESIntelligence.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
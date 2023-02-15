using System.ComponentModel.DataAnnotations;

namespace XZQ.MESIntelligence.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}

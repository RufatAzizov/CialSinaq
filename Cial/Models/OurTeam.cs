using System.ComponentModel.DataAnnotations;

namespace Cial.Models
{
    public class OurTeam : BaseEntity
    {
        [Required, MinLength(5), MaxLength(30)]
        public string Title { get; set; }
        [Required]
        public string SocialMediaUrl { get; set; }
        

    }
}
